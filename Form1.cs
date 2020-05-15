using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Intel8086
{
    public partial class Form1 : Form
    {
        int type = 1;
        public Form1()
        {
            InitializeComponent();
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void numbertype(object sender, EventArgs e)
        {
            if(binarne.Checked)
            {
                type = 1;
            }
            else
            if(dziesietne.Checked)
            {
                type = 2;
            }
            else 
                if (hexa.Checked)
            {
                type = 3;
            }
            else
            if(pole.Checked)
            {
                type = 4;
            }
        }

        static string toBinary(int liczba=0)
        {

          string binary = Convert.ToString(liczba, 2);
          return binary;
          
        }
       
        static string toHex(int liczba=0)
        {
            string hexValue = liczba.ToString("X");
            return hexValue;
        }
        static string toDec(string binary)
        {
            string liczba= Convert.ToInt32(binary, 2).ToString();
            return liczba;
            
        }

       

        private void AH_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(AH.Text + AL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            AX_Hex.Text = tmp; 
                
             
        }

        private void AL_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(AH.Text + AL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            AX_Hex.Text = tmp; 
                
        }

        private void BH_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(BH.Text + BL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            BX_Hex.Text = tmp;
                
        }

        private void BL_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(BH.Text + BL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            BX_Hex.Text = tmp;
        }

        private void CH_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(CH.Text + CL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            CX_Hex.Text = tmp;
        }

        private void CL_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(CH.Text + CL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            CX_Hex.Text = tmp; 
            
        }

        private void DH_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(DH.Text + DL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            DX_Hex.Text = tmp; 
        }

        private void DL_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(DH.Text + DL.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            DX_Hex.Text = tmp;
        }

        private void BP_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(BP.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            BP_Hex.Text =tmp;
        }

        private void SP_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(SP.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            SP_Hex.Text = tmp;
        }

        private void SI_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(SI.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            SI_Hex.Text = tmp;
        }

        private void DI_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(DI.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            DI_Hex.Text = tmp;
        }

        private void CS_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(CS.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            CS_Hex.Text = tmp;
        }

        private void SS_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(SS.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            SS_Hex.Text = tmp;
        }

        private void DS_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(DS.Text)));
            if (tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            DS_Hex.Text = tmp;
        }

        private void ES_Update(object sender, EventArgs e)
        {
            string tmp = toHex(Int32.Parse(toDec(ES.Text)));
            if(tmp.Length == 1)
            {
                tmp = String.Concat("0" + tmp);
            }
            ES_Hex.Text = tmp;
        }


        private void randomize(object sender, EventArgs e)
        {
            AH.Text = Convert.ToString(random4b());
            AL.Text = Convert.ToString(random4b());
            BH.Text = Convert.ToString(random4b());
            BL.Text = Convert.ToString(random4b());
            CH.Text = Convert.ToString(random4b());
            CL.Text = Convert.ToString(random4b());
            DH.Text = Convert.ToString(random4b());
            DL.Text = Convert.ToString(random4b());
            SP.Text = Convert.ToString(random8b());
            SI.Text = Convert.ToString(random8b());
            DI.Text = Convert.ToString(random8b());
            CS.Text = Convert.ToString(random8b());
            SS.Text = Convert.ToString(random8b());
            DS.Text = Convert.ToString(random8b());
            ES.Text = Convert.ToString(random8b());
            BP.Text = Convert.ToString(random8b());


        }
        Random random = new Random();
        private int random8b()
        {
            int randomNumber = random.Next(0, 256);
            randomNumber = Int32.Parse(toBinary(randomNumber));

            while (randomNumber < 10000000)
            {
                randomNumber = randomNumber * 10;
            }
            return randomNumber;
        }
        private int random4b()
        {
            int randomNumber;
            randomNumber = random.Next(1, 16);
            randomNumber = Int32.Parse(toBinary(randomNumber));
            
            while(randomNumber < 1000)
            {
                randomNumber = randomNumber * 10;
            }
            return randomNumber;
        }

        private void clear(object sender, EventArgs e)
        {
            AH.Text = "0000";
            AL.Text = "0000";
            BH.Text = "0000";
            BL.Text = "0000";
            CH.Text = "0000";
            CL.Text = "0000";
            DH.Text = "0000";
            DL.Text = "0000";
            SP.Text = "00000000";
            SI.Text = "00000000";
            DI.Text = "00000000";
            CS.Text = "00000000";
            SS.Text = "00000000";
            DS.Text = "00000000";
            ES.Text = "00000000";
            BP.Text = "00000000";
        }

        private void Submit(object sender, EventArgs e)
        {
            try
            {
                switch (input1.Text)
                {
                    case "AH":

                        switch (type)
                        {
                            case 1: if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    AH.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); } 
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0) 
                                { AH.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3: if (input2.Text.Length < 2)
                                {
                                    AH.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4: switch (input2.Text)
                                {
                                    case "AH": AH.Text = AH.Text; break;
                                    case "AL": AH.Text = AL.Text;  break;
                                    case "BH": AH.Text = BH.Text;  break;
                                    case "BL": AH.Text = BL.Text;  break;
                                    case "CH": AH.Text = CH.Text;  break;
                                    case "CL": AH.Text = CL.Text;  break;
                                    case "DH": AH.Text = DH.Text;  break;
                                    case "DL": AH.Text = DL.Text;  break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                } break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    
                    case "AL":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    AL.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16)
                                { AL.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    AL.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": AL.Text = AH.Text; break;
                                    case "AL": AL.Text = AL.Text; break;
                                    case "BH": AL.Text = BH.Text; break;
                                    case "BL": AL.Text = BL.Text; break;
                                    case "CH": AL.Text = CH.Text; break;
                                    case "CL": AL.Text = CL.Text; break;
                                    case "DH": AL.Text = DH.Text; break;
                                    case "DL": AL.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "BH":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    BH.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0)
                                { BH.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    BH.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": BH.Text = AH.Text; break;
                                    case "AL": BH.Text = AL.Text; break;
                                    case "BH": BH.Text = BH.Text; break;
                                    case "BL": BH.Text = BL.Text; break;
                                    case "CH": BH.Text = CH.Text; break;
                                    case "CL": BH.Text = CL.Text; break;
                                    case "DH": BH.Text = DH.Text; break;
                                    case "DL": BH.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "BL":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    BL.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0)
                                { BL.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    BL.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": BL.Text = AH.Text; break;
                                    case "AL": BL.Text = AL.Text; break;
                                    case "BH": BL.Text = BH.Text; break;
                                    case "BL": BL.Text = BL.Text; break;
                                    case "CH": BL.Text = CH.Text; break;
                                    case "CL": BL.Text = CL.Text; break;
                                    case "DH": BL.Text = DH.Text; break;
                                    case "DL": BL.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "CH":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    CH.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0)
                                { CH.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    CH.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": CH.Text = AH.Text; break;
                                    case "AL": CH.Text = AL.Text; break;
                                    case "BH": CH.Text = BH.Text; break;
                                    case "BL": CH.Text = BL.Text; break;
                                    case "CH": CH.Text = CH.Text; break;
                                    case "CL": CH.Text = CL.Text; break;
                                    case "DH": CH.Text = DH.Text; break;
                                    case "DL": CH.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "CL":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    CL.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2: if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0) { CL.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    CL.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": CL.Text = AH.Text; break;
                                    case "AL": CL.Text = AL.Text; break;
                                    case "BH": CL.Text = BH.Text; break;
                                    case "BL": CL.Text = BL.Text; break;
                                    case "CH": CL.Text = CH.Text; break;
                                    case "CL": CL.Text = CL.Text; break;
                                    case "DH": CL.Text = DH.Text; break;
                                    case "DL": CL.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "DH":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    DH.Text = tmp; break;



                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16 && Convert.ToInt32(input2.Text) >= 0)
                                { DH.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    DH.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": DH.Text = AH.Text; break;
                                    case "AL": DH.Text = AL.Text; break;
                                    case "BH": DH.Text = BH.Text; break;
                                    case "BL": DH.Text = BL.Text; break;
                                    case "CH": DH.Text = CH.Text; break;
                                    case "CL": DH.Text = CL.Text; break;
                                    case "DH": DH.Text = DH.Text; break;
                                    case "DL": DH.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "DL":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 4)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 4)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }

                                    DL.Text = tmp; break;

                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 16)
                                { DL.Text = toBinary(Int32.Parse(input2.Text)); break; }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 2)
                                {
                                    DL.Text = toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber));
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                break;
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AH": DL.Text = AH.Text; break;
                                    case "AL": DL.Text = AL.Text; break;
                                    case "BH": DL.Text = BH.Text; break;
                                    case "BL": DL.Text = BL.Text; break;
                                    case "CH": DL.Text = CH.Text; break;
                                    case "CL": DL.Text = CL.Text; break;
                                    case "DH": DL.Text = DH.Text; break;
                                    case "DL": DL.Text = DL.Text; break;
                                    case "AX": throw new Exception("Index is too large");
                                    case "BX": throw new Exception("Index is too large");
                                    case "CX": throw new Exception("Index is too large");
                                    case "DX": throw new Exception("Index is too large");
                                    case "BP": throw new Exception("Index is too large");
                                    case "SP": throw new Exception("Index is too large");
                                    case "SI": throw new Exception("Index is too large");
                                    case "DI": throw new Exception("Index is too large");
                                    case "CS": throw new Exception("Index is too large");
                                    case "SS": throw new Exception("Index is too large");
                                    case "DS": throw new Exception("Index is too large");
                                    case "ES": throw new Exception("Index is too large");

                                    default: throw new Exception("There's no such an index");




                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "AX":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while(tmp.Length <8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    AH.Text = tmp.Substring(0, 4);
                                    AL.Text = tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                { string AX_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while(AX_Tmp.Length < 8)
                                    {
                                        AX_Tmp = String.Concat("0" + AX_Tmp);
                                    }
                                    AH.Text = AX_Tmp.Substring(0, 4);
                                    AL.Text = AX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string AX_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (AX_Tmp.Length < 8)
                                    {
                                        AX_Tmp = String.Concat("0" + AX_Tmp);
                                    }
                                    AH.Text = AX_Tmp.Substring(0, 4);
                                    AL.Text = AX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }

                                
                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": AH.Text = AH.Text; AL.Text=AL.Text; break;
                                    case "BX": AH.Text = BH.Text; AL.Text = BL.Text; break;
                                    case "CX": AH.Text = CH.Text; AL.Text = CL.Text; break;
                                    case "DX": AH.Text = DH.Text; AL.Text = DL.Text; break;
                                    case "BP": AH.Text = BP.Text.Substring(0, 4); AL.Text = BP.Text.Substring(4, 4); break;
                                    case "SP": AH.Text = SP.Text.Substring(0, 4); AL.Text = SP.Text.Substring(4, 4); break;
                                    case "SI": AH.Text = SI.Text.Substring(0, 4); AL.Text = SI.Text.Substring(4, 4); break;
                                    case "DI": AH.Text = DI.Text.Substring(0, 4); AL.Text = DI.Text.Substring(4, 4); break;
                                    case "CS": AH.Text = CS.Text.Substring(0, 4); AL.Text = CS.Text.Substring(4, 4); break;
                                    case "SS": AH.Text = SS.Text.Substring(0, 4); AL.Text = SS.Text.Substring(4, 4); break;
                                    case "DS": AH.Text = DS.Text.Substring(0, 4); AL.Text = DS.Text.Substring(4, 4); break;
                                    case "ES": AH.Text = ES.Text.Substring(0, 4); AL.Text = ES.Text.Substring(4, 4); break;
                                    case "AH": AL.Text = AH.Text; AH.Text = "0000";  break;
                                    case "AL": AL.Text = AL.Text; AH.Text = "0000"; break;
                                    case "BH": AL.Text = BH.Text; AH.Text = "0000"; break;
                                    case "BL": AL.Text = BL.Text; AH.Text = "0000"; break;
                                    case "CH": AL.Text = CH.Text; AH.Text = "0000"; break;
                                    case "CL": AL.Text = CL.Text; AH.Text = "0000"; break;
                                    case "DH": AL.Text = DH.Text; AH.Text = "0000"; break;
                                    case "DL": AL.Text = DL.Text; AH.Text = "0000"; break;
                                    default: throw new Exception("There's no such an index");
                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "BX":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    BH.Text = tmp.Substring(0, 4);
                                    BL.Text = tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string BX_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (BX_Tmp.Length < 8)
                                    {
                                        BX_Tmp = String.Concat("0" + BX_Tmp);
                                    }
                                    BH.Text = BX_Tmp.Substring(0, 4);
                                    BL.Text = BX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string BX_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (BX_Tmp.Length < 8)
                                    {
                                        BX_Tmp = String.Concat("0" + BX_Tmp);
                                    }
                                    BH.Text = BX_Tmp.Substring(0, 4);
                                    BL.Text = BX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": BH.Text = AH.Text; BL.Text = AL.Text; break;
                                    case "BX": BH.Text = BH.Text; BL.Text = BL.Text; break;
                                    case "CX": BH.Text = CH.Text; BL.Text = CL.Text; break;
                                    case "DX": BH.Text = DH.Text; BL.Text = DL.Text; break;
                                    case "BP": BH.Text = BP.Text.Substring(0, 4); BL.Text = BP.Text.Substring(4, 4); break;
                                    case "SP": BH.Text = SP.Text.Substring(0, 4); BL.Text = SP.Text.Substring(4, 4); break;
                                    case "SI": BH.Text = SI.Text.Substring(0, 4); BL.Text = SI.Text.Substring(4, 4); break;
                                    case "DI": BH.Text = DI.Text.Substring(0, 4); BL.Text = DI.Text.Substring(4, 4); break;
                                    case "CS": BH.Text = CS.Text.Substring(0, 4); BL.Text = CS.Text.Substring(4, 4); break;
                                    case "SS": BH.Text = SS.Text.Substring(0, 4); BL.Text = SS.Text.Substring(4, 4); break;
                                    case "DS": BH.Text = DS.Text.Substring(0, 4); BL.Text = DS.Text.Substring(4, 4); break;
                                    case "ES": BH.Text = ES.Text.Substring(0, 4); BL.Text = ES.Text.Substring(4, 4); break;
                                    case "AH": BL.Text = AH.Text; BH.Text = "0000"; break;
                                    case "AL": BL.Text = AL.Text; BH.Text = "0000"; break;
                                    case "BH": BL.Text = BH.Text; BH.Text = "0000"; break;
                                    case "BL": BL.Text = BL.Text; BH.Text = "0000"; break;
                                    case "CH": BL.Text = CH.Text; BH.Text = "0000"; break;
                                    case "CL": BL.Text = CL.Text; BH.Text = "0000"; break;
                                    case "DH": BL.Text = DH.Text; BH.Text = "0000"; break;
                                    case "DL": BL.Text = DL.Text; BH.Text = "0000"; break;
                                    default: throw new Exception("There's no such an index");




                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "CX":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    CH.Text = tmp.Substring(0, 4);
                                    CL.Text = tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string CX_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (CX_Tmp.Length < 8)
                                    {
                                        CX_Tmp = String.Concat("0" + CX_Tmp);
                                    }
                                    CH.Text = CX_Tmp.Substring(0, 4);
                                    CL.Text = CX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string CX_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (CX_Tmp.Length < 8)
                                    {
                                        CX_Tmp = String.Concat("0" + CX_Tmp);
                                    }
                                    CH.Text = CX_Tmp.Substring(0, 4);
                                    CL.Text = CX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": CH.Text = AH.Text; CL.Text = AL.Text; break;
                                    case "BX": CH.Text = BH.Text; CL.Text = BL.Text; break;
                                    case "CX": CH.Text = CH.Text; CL.Text = CL.Text; break;
                                    case "DX": CH.Text = DH.Text; CL.Text = DL.Text; break;
                                    case "BP": CH.Text = BP.Text.Substring(0, 4); CL.Text = BP.Text.Substring(4, 4); break;
                                    case "SP": CH.Text = SP.Text.Substring(0, 4); CL.Text = SP.Text.Substring(4, 4); break;
                                    case "SI": CH.Text = SI.Text.Substring(0, 4); CL.Text = SI.Text.Substring(4, 4); break;
                                    case "DI": CH.Text = DI.Text.Substring(0, 4); CL.Text = DI.Text.Substring(4, 4); break;
                                    case "CS": CH.Text = CS.Text.Substring(0, 4); CL.Text = CS.Text.Substring(4, 4); break;
                                    case "SS": CH.Text = SS.Text.Substring(0, 4); CL.Text = SS.Text.Substring(4, 4); break;
                                    case "DS": CH.Text = DS.Text.Substring(0, 4); CL.Text = DS.Text.Substring(4, 4); break;
                                    case "ES": CH.Text = ES.Text.Substring(0, 4); CL.Text = ES.Text.Substring(4, 4); break;
                                    case "AH": CL.Text = AH.Text; CH.Text = "0000"; break;
                                    case "AL": CL.Text = AL.Text; CH.Text = "0000"; break;
                                    case "BH": CL.Text = BH.Text; CH.Text = "0000"; break;
                                    case "BL": CL.Text = BL.Text; CH.Text = "0000"; break;
                                    case "CH": CL.Text = CH.Text; CH.Text = "0000"; break;
                                    case "CL": CL.Text = CL.Text; CH.Text = "0000"; break;
                                    case "DH": CL.Text = DH.Text; CH.Text = "0000"; break;
                                    case "DL": CL.Text = DL.Text; CH.Text = "0000"; break;
                                    default: throw new Exception("There's no such an index");




                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "DX":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    DH.Text = tmp.Substring(0, 4);
                                    DL.Text = tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string DX_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (DX_Tmp.Length < 8)
                                    {
                                        DX_Tmp = String.Concat("0" + DX_Tmp);
                                    }
                                    DH.Text = DX_Tmp.Substring(0, 4);
                                    DL.Text = DX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string DX_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (DX_Tmp.Length < 8)
                                    {
                                        DX_Tmp = String.Concat("0" + DX_Tmp);
                                    }
                                    DH.Text = DX_Tmp.Substring(0, 4);
                                    DL.Text = DX_Tmp.Substring(4, 4);
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": DH.Text = AH.Text; DL.Text = AL.Text; break;
                                    case "BX": DH.Text = BH.Text; DL.Text = BL.Text; break;
                                    case "CX": DH.Text = CH.Text; DL.Text = CL.Text; break;
                                    case "DX": DH.Text = DH.Text; DL.Text = DL.Text; break;
                                    case "BP": DH.Text = BP.Text.Substring(0, 4); DL.Text = BP.Text.Substring(4, 4); break;
                                    case "SP": DH.Text = SP.Text.Substring(0, 4); DL.Text = SP.Text.Substring(4, 4); break;
                                    case "SI": DH.Text = SI.Text.Substring(0, 4); DL.Text = SI.Text.Substring(4, 4); break;
                                    case "DI": DH.Text = DI.Text.Substring(0, 4); DL.Text = DI.Text.Substring(4, 4); break;
                                    case "CS": DH.Text = CS.Text.Substring(0, 4); DL.Text = CS.Text.Substring(4, 4); break;
                                    case "SS": DH.Text = SS.Text.Substring(0, 4); DL.Text = SS.Text.Substring(4, 4); break;
                                    case "DS": DH.Text = DS.Text.Substring(0, 4); DL.Text = DS.Text.Substring(4, 4); break;
                                    case "ES": DH.Text = ES.Text.Substring(0, 4); DL.Text = ES.Text.Substring(4, 4); break;
                                    case "AH": DL.Text = AH.Text; DH.Text = "0000"; break;
                                    case "AL": DL.Text = AL.Text; DH.Text = "0000"; break;
                                    case "BH": DL.Text = BH.Text; DH.Text = "0000"; break;
                                    case "BL": DL.Text = BL.Text; DH.Text = "0000"; break;
                                    case "CH": DL.Text = CH.Text; DH.Text = "0000"; break;
                                    case "CL": DL.Text = CL.Text; DH.Text = "0000"; break;
                                    case "DH": DL.Text = DH.Text; DH.Text = "0000"; break;
                                    case "DL": DL.Text = DL.Text; DH.Text = "0000"; break;
                                    default: throw new Exception("There's no such an index");




                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "BP":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    BP.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string BP_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (BP_Tmp.Length < 8)
                                    {
                                        BP_Tmp = String.Concat("0" + BP_Tmp);
                                    }
                                    BP.Text = BP_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string BP_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (BP_Tmp.Length < 8)
                                    {
                                        BP_Tmp = String.Concat("0" + BP_Tmp);
                                    }
                                    BP.Text = BP_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": BP.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": BP.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": BP.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": BP.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": BP.Text = BP.Text; break;
                                    case "SP": BP.Text = SP.Text; break;
                                    case "SI": BP.Text = SI.Text; break;
                                    case "DI": BP.Text = DI.Text; break;
                                    case "CS": BP.Text = CS.Text; break;
                                    case "SS": BP.Text = SS.Text; break;
                                    case "DS": BP.Text = DS.Text; break;
                                    case "ES": BP.Text = ES.Text; break;
                                    case "AH": BP.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": BP.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": BP.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": BP.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": BP.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": BP.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": BP.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": BP.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "SP":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    SP.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string SP_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (SP_Tmp.Length < 8)
                                    {
                                        SP_Tmp = String.Concat("0" + SP_Tmp);
                                    }
                                    SP.Text = SP_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string SP_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (SP_Tmp.Length < 8)
                                    {
                                        SP_Tmp = String.Concat("0" + SP_Tmp);
                                    }
                                    SP.Text = SP_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": SP.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": SP.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": SP.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": SP.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": SP.Text = BP.Text; break;
                                    case "SP": SP.Text = SP.Text; break;
                                    case "SI": SP.Text = SI.Text; break;
                                    case "DI": SP.Text = DI.Text; break;
                                    case "CS": SP.Text = CS.Text; break;
                                    case "SS": SP.Text = SS.Text; break;
                                    case "DS": SP.Text = DS.Text; break;
                                    case "ES": SP.Text = ES.Text; break;
                                    case "AH": SP.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": SP.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": SP.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": SP.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": SP.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": SP.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": SP.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": SP.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "SI":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    SI.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string SI_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (SI_Tmp.Length < 8)
                                    {
                                        SI_Tmp = String.Concat("0" + SI_Tmp);
                                    }
                                    SI.Text = SI_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string SI_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (SI_Tmp.Length < 8)
                                    {
                                        SI_Tmp = String.Concat("0" + SI_Tmp);
                                    }
                                    SI.Text = SI_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": SI.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": SI.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": SI.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": SI.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": SI.Text = BP.Text; break;
                                    case "SP": SI.Text = SP.Text; break;
                                    case "SI": SI.Text = SI.Text; break;
                                    case "DI": SI.Text = DI.Text; break;
                                    case "CS": SI.Text = CS.Text; break;
                                    case "SS": SI.Text = SS.Text; break;
                                    case "DS": SI.Text = DS.Text; break;
                                    case "ES": SI.Text = ES.Text; break;
                                    case "AH": SI.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": SI.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": SI.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": SI.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": SI.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": SI.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": SI.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": SI.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "DI":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    DI.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string DI_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (DI_Tmp.Length < 8)
                                    {
                                        DI_Tmp = String.Concat("0" + DI_Tmp);
                                    }
                                    DI.Text = DI_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string DI_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (DI_Tmp.Length < 8)
                                    {
                                        DI_Tmp = String.Concat("0" + DI_Tmp);
                                    }
                                    DI.Text = DI_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": DI.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": DI.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": DI.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": DI.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": DI.Text = BP.Text; break;
                                    case "SP": DI.Text = SP.Text; break;
                                    case "SI": DI.Text = SI.Text; break;
                                    case "DI": DI.Text = DI.Text; break;
                                    case "CS": DI.Text = CS.Text; break;
                                    case "SS": DI.Text = SS.Text; break;
                                    case "DS": DI.Text = DS.Text; break;
                                    case "ES": DI.Text = ES.Text; break;
                                    case "AH": DI.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": DI.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": DI.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": DI.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": DI.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": DI.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": DI.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": DI.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "CS":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    CS.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string CS_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (CS_Tmp.Length < 8)
                                    {
                                        CS_Tmp = String.Concat("0" + CS_Tmp);
                                    }
                                    CS.Text = CS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string CS_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (CS_Tmp.Length < 8)
                                    {
                                        CS_Tmp = String.Concat("0" + CS_Tmp);
                                    }
                                    CS.Text = CS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": CS.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": CS.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": CS.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": CS.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": CS.Text = BP.Text; break;
                                    case "SP": CS.Text = SP.Text; break;
                                    case "SI": CS.Text = SI.Text; break;
                                    case "DI": CS.Text = DI.Text; break;
                                    case "CS": CS.Text = CS.Text; break;
                                    case "SS": CS.Text = SS.Text; break;
                                    case "DS": CS.Text = DS.Text; break;
                                    case "ES": CS.Text = ES.Text; break;
                                    case "AH": CS.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": CS.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": CS.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": CS.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": CS.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": CS.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": CS.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": CS.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "SS":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    SS.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string SS_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (SS_Tmp.Length < 8)
                                    {
                                        SS_Tmp = String.Concat("0" + SS_Tmp);
                                    }
                                    SS.Text = SS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string SS_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (SS_Tmp.Length < 8)
                                    {
                                        SS_Tmp = String.Concat("0" + SS_Tmp);
                                    }
                                    SS.Text = SS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": SS.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": SS.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": SS.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": SS.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": SS.Text = BP.Text; break;
                                    case "SP": SS.Text = SP.Text; break;
                                    case "SI": SS.Text = SI.Text; break;
                                    case "DI": SS.Text = DI.Text; break;
                                    case "CS": SS.Text = CS.Text; break;
                                    case "SS": SS.Text = SS.Text; break;
                                    case "DS": SS.Text = DS.Text; break;
                                    case "ES": SS.Text = ES.Text; break;
                                    case "AH": SS.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": SS.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": SS.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": SS.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": SS.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": SS.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": SS.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": SS.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "DS":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    DS.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string DS_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (DS_Tmp.Length < 8)
                                    {
                                        DS_Tmp = String.Concat("0" + DS_Tmp);
                                    }
                                    DS.Text = DS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string DS_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (DS_Tmp.Length < 8)
                                    {
                                        DS_Tmp = String.Concat("0" + DS_Tmp);
                                    }
                                    DS.Text = DS_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": DS.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": DS.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": DS.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": DS.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": DS.Text = BP.Text; break;
                                    case "SP": DS.Text = SP.Text; break;
                                    case "SI": DS.Text = SI.Text; break;
                                    case "DI": DS.Text = DI.Text; break;
                                    case "CS": DS.Text = CS.Text; break;
                                    case "SS": DS.Text = SS.Text; break;
                                    case "DS": DS.Text = DS.Text; break;
                                    case "ES": DS.Text = ES.Text; break;
                                    case "AH": DS.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": DS.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": DS.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": DS.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": DS.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": DS.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": DS.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": DS.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    case "ES":

                        switch (type)
                        {
                            case 1:
                                if (input2.Text.Length <= 8)
                                {
                                    string tmp = input2.Text;
                                    while (tmp.Length < 8)
                                    {
                                        tmp = String.Concat("0" + tmp);
                                    }
                                    ES.Text = tmp;
                                    break;
                                }
                                else
                                { throw new ArgumentException("Nieodpowiednia długość tekstu"); }
                            case 2:
                                if (Convert.ToInt32(input2.Text) < 256 && Convert.ToInt32(input2.Text) >= 0)
                                {
                                    string ES_Tmp = Convert.ToString(toBinary(Int32.Parse(input2.Text)));
                                    while (ES_Tmp.Length < 8)
                                    {
                                        ES_Tmp = String.Concat("0" + ES_Tmp);
                                    }
                                    ES.Text = ES_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Nieprawidłowa wartość");
                                }
                            case 3:
                                if (input2.Text.Length < 4)
                                {
                                    string ES_Tmp = Convert.ToString(toBinary(int.Parse(input2.Text, System.Globalization.NumberStyles.HexNumber)));
                                    while (ES_Tmp.Length < 8)
                                    {
                                        ES_Tmp = String.Concat("0" + ES_Tmp);
                                    }
                                    ES.Text = ES_Tmp;
                                    break;
                                }
                                else
                                {
                                    throw new ArgumentException("Zbyt długi ciąg znaków");
                                }


                            case 4:
                                switch (input2.Text)
                                {
                                    case "AX": ES.Text = String.Concat(AH.Text, AL.Text); break;
                                    case "BX": ES.Text = String.Concat(BH.Text, BL.Text); break;
                                    case "CX": ES.Text = String.Concat(CH.Text, CL.Text); break;
                                    case "DX": ES.Text = String.Concat(DH.Text, DL.Text); break;
                                    case "BP": ES.Text = BP.Text; break;
                                    case "SP": ES.Text = SP.Text; break;
                                    case "SI": ES.Text = SI.Text; break;
                                    case "DI": ES.Text = DI.Text; break;
                                    case "CS": ES.Text = CS.Text; break;
                                    case "SS": ES.Text = SS.Text; break;
                                    case "DS": ES.Text = DS.Text; break;
                                    case "ES": ES.Text = ES.Text; break;
                                    case "AH": ES.Text = String.Concat("0000" + AH.Text); break;
                                    case "AL": ES.Text = String.Concat("0000" + AL.Text); break;
                                    case "BH": ES.Text = String.Concat("0000" + BH.Text); break;
                                    case "BL": ES.Text = String.Concat("0000" + BL.Text); break;
                                    case "CH": ES.Text = String.Concat("0000" + CH.Text); break;
                                    case "CL": ES.Text = String.Concat("0000" + CL.Text); break;
                                    case "DH": ES.Text = String.Concat("0000" + DH.Text); break;
                                    case "DL": ES.Text = String.Concat("0000" + DL.Text); break;
                                    default: throw new Exception("There's no such an index");

                                }
                                break;
                            default: throw new Exception("Something went wrong");
                        }
                        break;
                    default: throw new Exception("Something went wrong"); 


                }
                
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                }
        }
    }
}

// Move