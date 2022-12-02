using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Calculadora : ContentPage
	{
		public Calculadora ()
		{
			InitializeComponent ();
            resultado.Clicked += Resultado_Clicked;
            ac.Clicked += Ac_Clicked;
            apaga.Clicked += Apaga_Clicked;
            um.Clicked += Um_Clicked;
            dois.Clicked += Dois_Clicked;
            tres.Clicked += Tres_Clicked;
            quatro.Clicked += Quatro_Clicked;
            cinco.Clicked += Cinco_Clicked;
            seis.Clicked += Seis_Clicked;
            sete.Clicked += Sete_Clicked;
            oito.Clicked += Oito_Clicked;
            nove.Clicked += Nove_Clicked;
            soma.Clicked += Soma_Clicked;
            subtrai.Clicked += Subtrai_Clicked;
            multiplica.Clicked += Multiplica_Clicked;
            divide.Clicked += Divide_Clicked;
            zero.Clicked += Zero_Clicked;
        }

       

        private void Divide_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "/";
            expressao.Text = ex;
        }

        private void Multiplica_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "x";
            expressao.Text = ex;
        }

        private void Subtrai_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "-";
            expressao.Text = ex;
        }

        private void Soma_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "+";
            expressao.Text = ex;
        }
        private void Zero_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "0";
            expressao.Text = ex;
        }
        private void Nove_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "9";
            expressao.Text = ex;
        }

        private void Oito_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "8";
            expressao.Text = ex;
        }

        private void Sete_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "7";
            expressao.Text = ex;
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "6";
            expressao.Text = ex;
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "5";
            expressao.Text = ex;
        }

        private void Quatro_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "4";
            expressao.Text = ex;
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "3";
            expressao.Text = ex;
        }

        private void Dois_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "2";
            expressao.Text = ex;
        }

        private void Um_Clicked(object sender, EventArgs e)
        {
            string ex = expressao.Text;
            ex += "1";
            expressao.Text = ex;

        }

        private void Apaga_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                string ex = expressao.Text;
                if(ex!=null)
                    expressao.Text = ex.Remove(ex.Length - 1);

            }
            catch (Exception)
            {
            }
			

        }

        private void Ac_Clicked(object sender, EventArgs e)
        {
			expressao.Text = string.Empty;
        }

        private void Resultado_Clicked(object sender, EventArgs e)
        {
            try
            {
                char[] param = { '+', 'x', '-', '/' };
                string strexpressao = expressao.Text;
                string[] valores = strexpressao.Split(param);
                float res = 0;
                if(valores.Length > 1)
                {
                    if (strexpressao.Contains('+'))
                    {
                        res = float.Parse(valores[0]) + float.Parse(valores[1]);
                    }
                    else if (strexpressao.Contains("-"))
                    {
                        res = float.Parse(valores[0]) - float.Parse(valores[1]);
                    }
                    else if (strexpressao.Contains("/"))
                    {
                        res = float.Parse(valores[0]) / float.Parse(valores[1]);
                    }
                    else if (strexpressao.Contains("x"))
                    {
                        res = float.Parse(valores[0]) * float.Parse(valores[1]);
                    }
                    expressao.Text = res.ToString();
                }
                
            }
            catch (Exception)
            {
            }
			

        }
    }
}