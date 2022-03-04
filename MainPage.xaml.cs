using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Pm1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void Desglosar_Clicked(object sender, EventArgs e)
        {

            //Capturamos datos ingresados 
            float n1 = Convert.ToSingle(numero1.Text);
           
                int G1, C200, C100, C50, C20, C10, C5, sob;
                C200 = C100 = C50 = C20 = C10 = C5 = 0;

                float G2, c50, c25, c10, c5, c1, CAN;
                c50 = c25 = c10 = c5 = c1 = 0.0f;

                float sc50, sc25, sc10, sc5;
                sc50 = sc25 = sc10 = sc5 = 0.0f;

            String a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, h1;
            h1 = "¿Quieres desglosar esta cantidad?";

            CAN = n1;

                if ((CAN >= 200))
                {
                    C200 = (int)(CAN / 200);
                    CAN = CAN - (C200 * 200);
                }

                if ((CAN >= 100))
                {
                    C100 = (int)(CAN / 100);
                    CAN = CAN - (C100 * 100);
                }
                if ((CAN >= 50))
                {
                    C50 = (int)(CAN / 50);
                    CAN = CAN - (C50 * 50);
                }
                if ((CAN >= 20))
                {
                    C20 = (int)(CAN / 20);
                    CAN = CAN - (C20 * 20);
                }
                if ((CAN >= 10))
                {
                    C10 = (int)(CAN / 10);
                    CAN = CAN - (C10 * 10);
                }
                if ((CAN >= 5))
                {
                    C5 = (int)(CAN / 5);
                    CAN = CAN - (C5 * 5);
                }

                G1 = (int)CAN;
                sob = (int)CAN;
                G2 = (float)sob;
                CAN = (float)(-sob + CAN);

                //Centavos

                if (CAN >= 0.50f)
                {
                    c50 = (CAN / 0.50f);
                    sc50 = (-0.50f + CAN);

                }

                if ((sc50 >= 0.25f))
                {
                    c25 = (sc50 / 0.25f);
                    sc25 = (-0.25f + sc50);

                }

                if ((sc25 >= 0.10f))
                {
                    c10 = (sc25 / 0.10f);
                    sc10 = (-0.10f + sc25);
                }

                if ((sc10 >= 0.05f))
                {
                    c5 = (sc10 / 0.05f);
                    sc5 = (-0.05f + sc10);
                }

                if ((sc5 >= 0.01f))
                {
                    c1 = (sc5 / 0.01f) + 0.01f;

                }

            a1 = $"{C200}";
            a2 = $"{C100}";
            a3 = $"{C50}";
            a4 = $"{C20}";
            a5 = $"{C10}";
            a6 = $"{C5}";
            a7 = $"{G1}";

            a8 = $"{c50}";
            a9 = $"{c25}";
            a10 = $"{c10}";
            a11 = $"{c5}";
            a12 = $"{c1}";

           

            bool result=await DisplayAlert("",h1 ,"Confirmar","Cancelar");

            if(result== true) 
            {
               
                lblresult.Text = "BILLETES DE 200:  " + a1 + "\nBILLETES DE 100:  " + a2 + "\nBILLETES DE 50:  " + a3 + "\nBILLETES DE 20:  " + a4
                + "\nBILLETES DE 10:  " + a5 + "\nBILLETES DE 5:  " + a6 + "\nBILLETES DE 1:  " + a7 + "\n\nCENTAVOS" + "\nCENTAVOS DE 0.50:  " + a8
                + "\nCENTAVOS DE 0.25:  " + a9 + "\nCENTAVOS DE 0.10:  " + a10 + "\nCENTAVOS DE 0.05:  " + a11 + "\nCENTAVOS DE 0.01:  " + a12;
            }
            
            if(result==false)
            {
                
                lblresult.Text = "  ";
            }

        }

        private void Borrar_Clicked(object sender, EventArgs e)
        {
           
            numero1.Text = "  ";
            lblresult.Text = "  ";


        }
    }
}
