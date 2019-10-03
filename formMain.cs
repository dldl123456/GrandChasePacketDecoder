using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GrandChasePacketDecoder
{
    public partial class formMain : Form
    {
        private int decoding = 0;

        public formMain()
        {
            InitializeComponent();
        }

        private void decode()
        {
            decoding = 1;

            string packetText = textPacket.Text;
            string keyText = textKey.Text;

            if (packetText.Trim().Length == 0)
            {
                decoding = 0;
                return;
            }

            byte[] binary = null;
            byte[] key = null;

            try
            {
                binary = Util.str2hex(packetText);
                key = Util.str2hex(keyText);
            }
            catch (Exception ex)
            {
            }

            // DES 추출
            try
            {
                if (key == null)
                {
                    byte[] packet = PacketCrypto.DecryptAll(binary, PacketCrypto.GC_DES_KEY);
                    if (packet[0] == 0 && packet[1] == 1 && packet[12] == 8 && packet[24] == 8) // opcode: 1
                    {
                        byte[] temp = Util.ReadBytes(packet, 25, 8);
                        textKey.Text = Util.hex2str(temp);
                        decoding = 0;
                        return;
                    }
                }
            }
            catch (Exception ex)
            {

            }

            // 일반 패킷 복호화
            try
            {
                byte[] packet = PacketCrypto.DecryptAll(binary, key);
                string packetString = Util.hex2str(packet);
                textDecode.Text = packetString;

                // opcode
                int opcode = packet[0] * 256 + packet[1];

                // 히스토리에 추가
                ListViewItem item = new ListViewItem();
                DateTime now = System.DateTime.Now;
                string time = now.Hour + ":" + now.Minute + ":" + now.Second;
                item.Text = "[" + time + "] OPCODE: " + opcode;
                item.Tag = keyText + "|" + packetText + "|" + packetString;
                listHistory.Items.Add(item);
            }
            catch (Exception ex)
            {
            }

            decoding = 0;
        }

        private void textPacket_TextChanged(object sender, EventArgs e)
        {
            if (decoding == 1)
            {
                return;
            }

            decode();
        }

        private void listHistory_DoubleClick(object sender, EventArgs e)
        {
            if(listHistory.SelectedItem == null) {
                return;
            }

            ListViewItem item = (ListViewItem)listHistory.SelectedItem;
            string tag = (string)item.Tag;
            string[] token = tag.Split('|');

            decoding = 1;

            textKey.Text = token[0];
            textPacket.Text = token[1];
            textDecode.Text = token[2];

            decoding = 0;
        }

    }
}
