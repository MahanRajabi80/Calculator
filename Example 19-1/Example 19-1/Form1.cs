using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_19_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //---------------------------------------------------------------
        Label outputLabel = new Label();
        Button MC = new Button();
        Button MR = new Button();
        Button MS = new Button();
        Button MPlus = new Button();
        Button MMines = new Button();
        Button BackSpace = new Button();
        Button CE=new Button();
        Button C=new Button();
        Button PlusMines=new Button();
        Button Radikal=new Button();
        Button B7=new Button();
        Button B8=new Button();
        Button B9=new Button();
        Button Slash=new Button();
        Button Mod=new Button();
        Button B4=new Button();
        Button B5=new Button();
        Button B6=new Button();
        Button Star=new Button();
        Button VaronX=new Button();
        Button B1=new Button();
        Button B2=new Button();
        Button B3=new Button();
        Button Mines=new Button();
        Button Equal=new Button();
        Button B0=new Button();
        Button Dot=new Button();
        Button Plus=new Button();
        //---------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //---set form
            this.Text = "Calculator";
            this.MaximizeBox = false;
            this.Size=new Size(230,290);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            //---set outputLabel
            outputLabel.BackColor = Color.White;
            outputLabel.AutoSize = false;
            outputLabel.BorderStyle = BorderStyle.FixedSingle;
            outputLabel.Size = new Size(190, 30);
            outputLabel.Location = new Point(10, 10);
            outputLabel.Text = "0";
            outputLabel.Font = new Font(outputLabel.Font.FontFamily, 14);
            outputLabel.TextAlign = ContentAlignment.MiddleRight;
            this.Controls.Add(outputLabel);
            //---set MC
            MC.Text = "MC";
            MC.Location = new Point(10, 50);
            MC.Size = new Size(36, 30);
            MC.Click+=new EventHandler(AllButtons_Click);
            this.Controls.Add(MC);
            //---set MR
            MR.Text = "MR";
            MR.Location = new Point(48, 50);
            MR.Size = new Size(36, 30);
            MR.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(MR);
            //---set MS
            MS.Text = "MS";
            MS.Location = new Point(86, 50);
            MS.Size = new Size(36, 30);
            MS.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(MS);
            //---set M+
            MPlus.Text = "M+";
            MPlus.Location = new Point(124, 50);
            MPlus.Size = new Size(36, 30);
            MPlus.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(MPlus);
            //---set M-
            MMines.Text = "M-";
            MMines.Location = new Point(162, 50);
            MMines.Size = new Size(36, 30);
            MMines.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(MMines);
            //---set Backspace
            BackSpace.Text = "";
            BackSpace.Location = new Point(10, 82);
            BackSpace.Font = new Font("Wingdings 3", 15);
            BackSpace.Size = new Size(36, 30);
            BackSpace.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(BackSpace);
            //---set CE
            CE.Text = "CE";
            CE.Location = new Point(48, 82);
            CE.Size = new Size(36, 30);
            CE.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(CE);
            //---set C
            C.Text = "C";
            C.Location = new Point(86, 82);
            C.Size = new Size(36, 30);
            C.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(C);
            //---set PlusMines
            PlusMines.Text = "±";
            PlusMines.Location = new Point(124, 82);
            PlusMines.Size = new Size(36, 30);
            PlusMines.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(PlusMines);
            //---set Radikal
            Radikal.Text = "√";
            Radikal.Location = new Point(162, 82);
            Radikal.Size = new Size(36, 30);
            Radikal.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Radikal);
            //---set B7
            B7.Text = "7";
            B7.Location = new Point(10, 114);
            B7.Size = new Size(36, 30);
            B7.Font = new Font(B7.Font.FontFamily, 13);
            B7.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B7);
            //---set B8
            B8.Text = "8";
            B8.Location = new Point(48, 114);
            B8.Size = new Size(36, 30);
            B8.Font = new Font(B8.Font.FontFamily, 13);
            B8.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B8);
            //---set B9
            B9.Text = "9";
            B9.Location = new Point(86, 114);
            B9.Size = new Size(36, 30);
            B9.Font = new Font(B9.Font.FontFamily, 13);
            B9.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B9);
            //---set Slash
            Slash.Text = "/";
            Slash.Location = new Point(124, 114);
            Slash.Size = new Size(36, 30);
            Slash.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Slash);
            //---set Mod
            Mod.Text = "%";
            Mod.Location = new Point(162, 114);
            Mod.Size = new Size(36, 30);
            Mod.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Mod);
            //---set B4
            B4.Text = "4";
            B4.Location = new Point(10, 146);
            B4.Size = new Size(36, 30);
            B4.Font = new Font(B4.Font.FontFamily, 13);
            B4.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B4);
            //---set B5
            B5.Text = "5";
            B5.Location = new Point(48, 146);
            B5.Size = new Size(36, 30);
            B5.Font = new Font(B5.Font.FontFamily, 13);
            B5.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B5);
            //---set B6
            B6.Text = "6";
            B6.Location = new Point(86, 146);
            B6.Size = new Size(36, 30);
            B6.Font = new Font(B6.Font.FontFamily, 13);
            B6.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B6);
            //---set Star
            Star.Text = "*";
            Star.Location = new Point(124, 146);
            Star.Size = new Size(36, 30);
            Star.Font = new Font(Star.Font.FontFamily, 12);
            Star.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Star);
            //---set 1/x
            VaronX.Text = "1/x";
            VaronX.Location = new Point(162, 146);
            VaronX.Size = new Size(36, 30);
            VaronX.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(VaronX);
            //---set B1
            B1.Text = "1";
            B1.Location = new Point(10, 178);
            B1.Size = new Size(36, 30);
            B1.Font = new Font(B1.Font.FontFamily, 13);
            B1.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B1);
            //---set B2
            B2.Text = "2";
            B2.Location = new Point(48, 178);
            B2.Size = new Size(36, 30);
            B2.Font = new Font(B2.Font.FontFamily, 13);
            B2.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B2);
            //---set B3
            B3.Text = "3";
            B3.Location = new Point(86, 178);
            B3.Size = new Size(36, 30);
            B3.Font = new Font(B3.Font.FontFamily, 13);
            B3.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B3);
            //---set Mines
            Mines.Text = "-";
            Mines.Location = new Point(124, 178);
            Mines.Size = new Size(36, 30);
            Mines.Font = new Font(Mines.Font.FontFamily, 12);
            Mines.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Mines);
            //---set Equal
            Equal.Text = "=";
            Equal.Location = new Point(162, 178);
            Equal.Size = new Size(36, 62);
            Equal.Font = new Font(Equal.Font.FontFamily, 13);
            Equal.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Equal);
            //---set B0
            B0.Text = "0";
            B0.Location = new Point(10, 210);
            B0.Size = new Size(74, 30);
            B0.Font = new Font(B0.Font.FontFamily, 13);
            B0.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(B0);
            //---set Dot
            Dot.Text = ".";
            Dot.Location = new Point(86, 210);
            Dot.Size = new Size(36, 30);
            Dot.Font = new Font(Dot.Font.FontFamily, 12);
            Dot.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Dot);
            //---set +
            Plus.Text = "+";
            Plus.Location = new Point(124, 210);
            Plus.Size = new Size(36, 30);
            Plus.Click += new EventHandler(AllButtons_Click);
            this.Controls.Add(Plus);
            //-----
            outputLabel.Focus();
        }
        //---------------------------------------------------------------
        double num1 = 0, num2 = 0;
        string op = "";
        bool first = true;
        //---------------------------------------------------------------
        private void AllButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            switch (b.Text)
            {
                case"0":case"1":case"2":case"3":case"4":case"5":case"6":case"7":case"8":case"9":
                    AddDigits(b.Text);
                    break;
                case "±":
                    ExecutePlusMines();
                    break;
                case ".":
                    ExecuteDot();
                    break;
                case "√":
                    ExecuteRadikal();
                    break;
                case "1/x":
                    ExecuteVaron();
                    break;
                case ""://backspace
                    ExecuteBackSpace();
                    break;
                case"C":case"CE":
                    ExecuteClear(b.Text);
                    break;
                case"MC":case"MR":case"MS":case"M+":case"M-":
                    ExecuteMemory(b.Text);
                    break;
                case"+":case"-":case"*":case"/":case"%":case"=":
                    Operator(b.Text);
                    break;
            }
            outputLabel.Focus();
        }
        //---------------------------------------------------------------
        private void AddDigits(string d)
        {
            //--add digit 0 to 9 in output
            if (outputLabel.Text.Length >= 16)  //max length
                return;
            if (outputLabel.Text == "0" || first)
            {
                outputLabel.Text = d;
                first = false;
            }
            else
                outputLabel.Text += d;
        }
        //---------------------------------------------------------------
        private void ExecutePlusMines()
        {
            //--execute ± 
            if (outputLabel.Text != "0")
                if (outputLabel.Text[0] != '-')
                    outputLabel.Text = outputLabel.Text.Insert(0, "-");
                else
                    outputLabel.Text = outputLabel.Text.Remove(0, 1);
        }
        //---------------------------------------------------------------
        private void ExecuteDot()
        {
            //--execute .
            if (first)
            {
                outputLabel.Text = "0.";
                first = false;
            }
            else if (outputLabel.Text.IndexOf('.') < 0)//not dot
                outputLabel.Text += ".";
        }
        //---------------------------------------------------------------
        private void ExecuteRadikal()
        {
            try
            {
                num1 = double.Parse(outputLabel.Text);
                num1 = Math.Sqrt(num1);
                outputLabel.Text = num1.ToString();
            }
            catch (Exception ex)
            {
                outputLabel.Text = "Error " + ex.Message;
                num1 = num2 = 0;
            }
            first = true;
        }
        //---------------------------------------------------------------
        private void ExecuteVaron()
        {
            try
            {
                num1 = double.Parse(outputLabel.Text);
                num1 = 1 / num1;
                outputLabel.Text = num1.ToString();
            }
            catch (Exception ex)
            {
                outputLabel.Text = "Error " + ex.Message;
                num1 = num2 = 0;
            }
            first = true;
        }
        //---------------------------------------------------------------
        private void ExecuteBackSpace()
        {
            if (outputLabel.Text == "0")
                return;
            outputLabel.Text = outputLabel.Text.Remove(outputLabel.Text.Length - 1, 1);
            if (outputLabel.Text == "")
                outputLabel.Text = "0";
        }
        //---------------------------------------------------------------
        private void ExecuteClear(string c)
        {
            outputLabel.Text = "0";//CE
            num2 = 0;//CE
            first = true;//CE
            if (c == "C")
            {
                num1 = 0;
                op = "";
            }
        }
        //---------------------------------------------------------------
        private void ExecuteMemory(string m)
        {
            //complete code here
            MessageBox.Show("کد این دکمه را کامل کنید");
            //----------------
        }
        //---------------------------------------------------------------
        private void Operator(string d)
        {
            //--execute +,-,*,/,%
            try
            {
                if (op == "")
                {
                    if (d != "=")
                    {
                        num1 = double.Parse(outputLabel.Text);
                        op = d;
                    }
                }
                else
                {
                    switch (op)
                    {
                        case "+":
                            num2 = double.Parse(outputLabel.Text);
                            num1 += num2;
                            outputLabel.Text = num1.ToString();
                            op = d;
                            break;
                        case "-":
                            num2 = double.Parse(outputLabel.Text);
                            num1 -= num2;
                            outputLabel.Text = num1.ToString();
                            op = d;
                            break;
                        case "*":
                            num2 = double.Parse(outputLabel.Text);
                            num1 *= num2;
                            outputLabel.Text = num1.ToString();
                            op = d;
                            break;
                        case "%":
                            num2 = double.Parse(outputLabel.Text);
                            num1 %= num2;
                            outputLabel.Text = num1.ToString();
                            op = d;
                            break;
                        case "/":
                            num2 = double.Parse(outputLabel.Text);
                            num1 /= num2;
                            outputLabel.Text = num1.ToString();
                            op = d;
                            if (outputLabel.Text == "Infinity")
                            {
                                throw new Exception("Infinity");
                            }
                            break;
                    }
                    if (d == "=")
                    {
                        op = "";
                    }
                }
                first = true;
            }
            catch (Exception ex)
            {
                outputLabel.Text = "Error " + ex.Message;
                op = "";
                first = true;
                num1 = 0;
                num2 = 0;
            }
        }
    }
}
