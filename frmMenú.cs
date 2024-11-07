using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Diagnostics.Eventing.Reader;
using System.Diagnostics.CodeAnalysis;
using winSemaforos.Models;

namespace winSemaforos
{
	public partial class frmMenú : Form
	{
		const int SEMAFOROS_NUMBER = 3;

		List<Semaforo> semaforos =
			new List<Semaforo>{
				new Semaforo
				{
					Id = 0,
					SemaforoStatus = SemaforoStatus.Apagado,
					Identifiers = new string[]{ "1" , "2", "3", "a", "b", "c"},
					IsCurrent = false
				},
				new Semaforo
				{
					Id = 1,
					SemaforoStatus = SemaforoStatus.Apagado,
					Identifiers = new string[] { "4", "5", "6", "d", "e", "f" },
					IsCurrent = false
				},
				new Semaforo
				{
					Id = 2,
					SemaforoStatus = SemaforoStatus.Apagado,
					Identifiers = new string[] { "7", "8", "9", "g", "h", "i" },
					IsCurrent = false
				}
		};

		int semaforo = 0, semaforo2 = 0, suma = 0;
		//variables semáforo 1
		int semaforo3 = 0, cverde = 0, camarillo = 0, z = 0, y = 0, crojo = 0, crojo2 = 0, cverde2 = 0, camarillo2 = 0, x = 0;
		//variables semaforo 2
		int cverdeb = 0, crojob = 0, camarillob = 0, camarillob2 = 0, cverdeb2 = 0, crojo2b = 0;
		double angle = 0; // Ángulo para el movimiento en curva
		int radius = 50; // Radio de la curva
		int centerX, centerY; // Centro de la curva
		int carSpeed = 5; // Velocidad de movimiento hacia el norte
						  //variables de papadeo
		bool xx = false, yy = false, zz = false;
		int cxx = 0, cyy = 0, czz = 0;

		Point startPos = new Point(74, 170);
		Point curvePos = new Point(220, 180);
		Point endPos = new Point(220, 9);

		Point startPosIzquierda = new Point(74, 170);
		Point startPosDerecha = new Point(300, 160);
		Point startPosRecto = new Point(220, 300);
		int speed = 5; // Velocidad de movimiento
		bool movingToCurve = true;
		int horizontalIzquierda = 0;
		int horizontalDerecha = 0;
		int horizontalRecto = 0;
		bool movingToCurveIzquierda = true;
		bool movingToCurveDerecha = true;
		bool movingToCurveRecto = true;
		// Resetear posición inicial
		// Empezar desde la fase de movimiento hacia la curva
		public frmMenú()
		{
			InitializeComponent();

			picCarroIzquierda.Location = startPosIzquierda;
			picCarroDerecha.Location = startPosDerecha;
			picCarroTrasero.Location = startPosRecto;

			centerX = this.Width / 2;
			centerY = this.Height / 2;
		}


		System.Drawing.Image[] Derecha = new System.Drawing.Image[]
		{
			Properties.Resources.Derecha1,
			Properties.Resources.Derecha2,
			Properties.Resources.Derecha3,
			Properties.Resources.Derecha4,
			Properties.Resources.Trasero_,

		};
		System.Drawing.Image[] Izquierda = new System.Drawing.Image[]
		{
			Properties.Resources.Izquierda1,
			Properties.Resources.Izquierda2,
			Properties.Resources.Izquierda3,
			Properties.Resources.Izquierda4,
			Properties.Resources.Trasero_,
		};
		System.Drawing.Image[] Recto = new System.Drawing.Image[]
		{
			Properties.Resources.Trasero_,
		};
		private void ResetCarPosition(PictureBox car)
		{
			// Reiniciar el carro en la parte inferior del formulario y restablecer el ángulo para iniciar la curva
			car.Top = this.Height;
			car.Left = centerX; // Opcionalmente, ajusta para que cada carro comience desde el centro
			angle = 0; // Reiniciar el ángulo para iniciar el movimiento en curva
		}

		private void tmrCarroIzquierda_Tick(object sender, EventArgs e)
		{
			if (movingToCurveIzquierda)
			{
				MoveTowards(picCarroIzquierda, curvePos);

				if (picCarroIzquierda.Location == curvePos)
				{
					movingToCurveIzquierda = false;
					horizontalIzquierda = 0; // Reiniciar la animación al primer cuadro
					StartAnimationIzquierda();
				}
			}
			else
			{
				MoveTowards(picCarroIzquierda, endPos);

				if (picCarroIzquierda.Location == endPos)
				{
					ResetCarPosition(picCarroIzquierda, startPosIzquierda, ref movingToCurveIzquierda);
					horizontalIzquierda = 0; // Reiniciar la animación al primer cuadro al llegar al borde
				}
			}
		}
		private async void StartAnimationIzquierda()
		{
			horizontalIzquierda = 0;
			while (horizontalIzquierda < Izquierda.Length)
			{
				picCarroIzquierda.Image = Izquierda[horizontalIzquierda];
				picCarroIzquierda.Refresh();
				horizontalIzquierda++;
				await Task.Delay(100);
			}
		}
		private void MoveTowards(PictureBox car, Point target)
		{
			int deltaX = target.X - car.Left;
			int deltaY = target.Y - car.Top;

			double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);

			if (distance > speed)
			{
				int moveX = (int)(speed * (deltaX / distance));
				int moveY = (int)(speed * (deltaY / distance));

				car.Left += moveX;
				car.Top += moveY;
			}
			else
			{
				car.Location = target;
			}
		}

		private void tmrRecto_Tick(object sender, EventArgs e)
		{
			if (movingToCurveRecto)
			{
				MoveTowards(picCarroTrasero, curvePos);

				if (picCarroTrasero.Location == curvePos)
				{
					movingToCurveRecto = false;
					horizontalRecto = 0; // Reiniciar la animación al primer cuadro
					StartAnimationRecto();
				}
			}
			else
			{
				MoveTowards(picCarroTrasero, endPos);

				if (picCarroTrasero.Location == endPos)
				{
					ResetCarPosition(picCarroTrasero, startPosRecto, ref movingToCurveRecto);
					horizontalRecto = 0; // Reiniciar la animación al primer cuadro al llegar al borde
				}
			}
		}

		private async void StartAnimationRecto()
		{
			horizontalRecto = 0;
			while (horizontalRecto < Recto.Length)
			{
				picCarroTrasero.Image = Recto[horizontalRecto];
				picCarroTrasero.Refresh();
				horizontalRecto++;
				await Task.Delay(100);
			}
		}
		private void ResetCarPosition(PictureBox car, Point startPos, ref bool movingToCurve)
		{
			car.Location = startPos;
			movingToCurve = true;

			// Reiniciar el índice de animación al primer cuadro específico del carro
			if (car == picCarroIzquierda)
			{
				horizontalIzquierda = 0;
				picCarroIzquierda.Image = Izquierda[horizontalIzquierda];
			}
			else if (car == picCarroDerecha)
			{
				horizontalDerecha = 0;
				picCarroDerecha.Image = Derecha[horizontalDerecha];
			}
			else if (car == picCarroTrasero)
			{
				horizontalRecto = 0;
				picCarroTrasero.Image = Recto[horizontalRecto];
			}
		}

		private void tmrCarroDerecha_Tick(object sender, EventArgs e)
		{
			if (movingToCurveDerecha)
			{
				MoveTowards(picCarroDerecha, curvePos);

				if (picCarroDerecha.Location == curvePos)
				{
					movingToCurveDerecha = false;
					horizontalDerecha = 0; // Reiniciar la animación al primer cuadro
					StartAnimationDerecha();
				}
			}
			else
			{
				MoveTowards(picCarroDerecha, endPos);

				if (picCarroDerecha.Location == endPos)
				{
					ResetCarPosition(picCarroDerecha, startPosDerecha, ref movingToCurveDerecha);
					horizontalDerecha = 0; // Reiniciar la animación al primer cuadro al llegar al borde
				}
			}
		}

		private void tmrParpadeo_Tick(object sender, EventArgs e)
		{
			//con zz
			if (zz == true)
			{
				if (czz % 2 != 0)
				{
					var semaforo = semaforos.Where(s => s.Id == 0).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = true;

					if(semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					czz++;
				}
				else
				{
					var semaforo = semaforos.Where(s => s.Id == 0).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = false;

					if (!semaforo.IsOn)
					{
						serialPort1.Write(semaforo.Identifiers[3]);
						serialPort1.Write(semaforo.Identifiers[4]);
						serialPort1.Write(semaforo.Identifiers[5]);
					}

					czz++;
				}

			}
		}

		private void tmrParpadeo2_Tick(object sender, EventArgs e)
		{
			//con yy
			if (yy == true)
			{
				if (cyy % 2 != 0)
				{
					var semaforo = semaforos.Where(s => s.Id == 1).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = true;

					if (semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);
					cyy++;
				}
				else
				{
					var semaforo = semaforos.Where(s => s.Id == 1).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = false;

					if (!semaforo.IsOn)
					{
						serialPort1.Write(semaforo.Identifiers[3]);
						serialPort1.Write(semaforo.Identifiers[4]);
						serialPort1.Write(semaforo.Identifiers[5]);
					}

					cyy++;
				}

			}
		}

		private void tmrParpadeo3_Tick(object sender, EventArgs e)
		{
			//con xx
			if (xx == true)
			{
				if (cxx % 2 != 0)
				{
					var semaforo = semaforos.Where(s => s.Id == 2).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = true;

					if (semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					cxx++;
				}
				else
				{
					var semaforo = semaforos.Where(s => s.Id == 2).First();

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					semaforo.IsOn = false;

					if (!semaforo.IsOn)
					{
						serialPort1.Write(semaforo.Identifiers[3]);
						serialPort1.Write(semaforo.Identifiers[4]);
						serialPort1.Write(semaforo.Identifiers[5]);
					}

					cxx++;
				}

			}
		}


		private async void StartAnimationDerecha()
		{
			horizontalDerecha = 0;
			while (horizontalDerecha < Derecha.Length)
			{
				picCarroDerecha.Image = Derecha[horizontalDerecha];
				picCarroDerecha.Refresh();
				horizontalDerecha++;
				await Task.Delay(100);
			}
		}
		private void btnParar_Click(object sender, EventArgs e)
		{
			if (tmrSemaforo1.Enabled == true)
			{
				tmrSemaforo1.Enabled = false;
				tmrSemaforo2.Enabled = false;
				tmrSemaforo3.Enabled = false;
				tmrCarroIzquierda.Enabled = false;
				tmrCarroDerecha.Enabled = false;
				tmrRecto.Enabled = false;
			}
			else
			{
				MessageBox.Show("El semáforo se encuentra pausado", "Error de pausa");
			}
		}

		private void tmrAnimacion_Tick(object sender, EventArgs e)
		{
			// Cambiar la imagen actual del carro a la siguiente en la secuencia para la animación
			picCarroIzquierda.Image = Izquierda[horizontalIzquierda];
			picCarroIzquierda.Refresh();  // Forzar la actualización

			// Incrementar el índice horizontal y detener la animación si se completa el recorrido
			horizontalIzquierda++;
			if (horizontalIzquierda >= Izquierda.Length)
			{
				tmrAnimacion.Stop(); // Detener la animación después de una vez
			}
		}

		private void tmrAnimacionDerecha_Tick(object sender, EventArgs e)
		{
			picCarroDerecha.Image = Derecha[horizontalDerecha];
			picCarroDerecha.Refresh();
			horizontalDerecha++;
			if (horizontalDerecha >= Derecha.Length)
			{
				tmrAnimacionDerecha.Stop();
			}

		}

		private void tmrAnimacionRecta_Tick(object sender, EventArgs e)
		{
			picCarroTrasero.Image = Recto[horizontalRecto];
			picCarroTrasero.Refresh();
			horizontalRecto++;
			if (horizontalRecto >= Recto.Length)
			{
				tmrAnimacionRecta.Stop();
			}
		}

		private void btnContinuar_Click(object sender, EventArgs e)
		{
			if (tmrSemaforo2.Enabled == false)
			{
				tmrSemaforo1.Enabled = true;
				tmrSemaforo2.Enabled = true;
				tmrSemaforo3.Enabled = true;
				tmrCarroIzquierda.Enabled = true;
				tmrCarroDerecha.Enabled = true;
				tmrRecto.Enabled = true;
			}
			else
			{
				MessageBox.Show("El semáforo está iniciado", "Error de inicio");
			}
		}

		//caribales semaforo 3
		int cverdec = 0, crojoc = 0, camarilloc = 0, camarilloc2 = 0, cverdec2 = 0, crojoc2 = 0;

		string[] puertosdisponibles = SerialPort.GetPortNames();

		private void SetInitialState()
		{
			List<int> estados = new List<int> { 3, 3, 1 }; // Dos semáforos en rojo (3) y uno en verde (1)

			// Mezclar la lista para asignar los valores de forma aleatoria
			Random rnd = new Random();
			estados = estados.OrderBy(x => rnd.Next()).ToList();

			foreach (var semaforo in semaforos)
			{
				semaforo.SemaforoStatus = (SemaforoStatus)estados[semaforo.Id];
			}

			foreach (var item in semaforos)
			{
				if (item.SemaforoStatus == SemaforoStatus.Rojo)
				{
					item.IsOn = true;
					serialPort1.Write(item.Identifiers[(int)item.SemaforoStatus]);
				}
				else if (item.SemaforoStatus == SemaforoStatus.Verde)
				{
					item.IsCurrent = true;
					item.IsOn = true;
					serialPort1.Write(item.Identifiers[(int)item.SemaforoStatus]);
				}
			}
		}

		void reiniciarContadores()
		{
			cverde = 0;
			camarillo = 0;
			crojo = 0; crojo2 = 0;
			cverde2 = 0;
			camarillo2 = 0;
			crojo2 = 0;
			cverdeb = 0;
			crojob = 0;
			camarillob = 0;
			camarillob2 = 0;
			cverdeb2 = 0;
			crojo2b = 0;
			cverdec = 0;
			crojoc = 0;
			camarilloc = 0;
			camarilloc2 = 0;
			cverdec2 = 0;
			crojoc2 = 0;
		}

        private void tmrSemaforo1_Tick(object sender, EventArgs e)
        {
			var semaforo = semaforos.Where(s => s.Id == 0).First();

			if (semaforo.IsCurrent)
			{

				if (cverde < 6) // 6 segundos en verde
				{
					semaforo.SemaforoStatus = SemaforoStatus.Verde;
					if (semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					tmrCarroIzquierda.Enabled = true;
					tmrRecto.Enabled = false;
					tmrCarroDerecha.Enabled = false;

					cverde++;
				}
				else if (camarillo < 3) // 3 segundos en amarillo después del verde
				{
					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;
					if (semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);
					tmrCarroIzquierda.Enabled = false; // Detiene el carro izquierda
					camarillo++;
				}
				else if (crojo < 15) // 15 segundos en rojo después del amarillo
				{
					semaforo.SemaforoStatus = SemaforoStatus.Rojo;
					if (semaforo.IsOn) serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);
					crojo++;
				}
				else
				{
					// Fin del ciclo del semáforo 1, inicia el semáforo 2
					semaforo.IsCurrent = false;
					semaforos[1].IsCurrent = true;
					reiniciarContadores();
					//tmrSemaforo1.Enabled = false;
					//tmrSemaforo2.Enabled = true;
				}
			}

        }

        private void btnManual_Click(object sender, EventArgs e)
        {
            txtSemaforo1.Enabled = true;
            txtSemaforo2.Enabled=true;
            txtSemaforo3.Enabled=true;
            grbManual.Visible = true;
        }

        private void btnActivar_Click(object sender, EventArgs e)
        {
            foreach (var semaforo in semaforos)
			{
				semaforo.SemaforoStatus = SemaforoStatus.Apagado;
				serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);
			}

            try
            {
                z = int.Parse(txtSemaforo1.Text);
                y = int.Parse(txtSemaforo2.Text);
                x = int.Parse(txtSemaforo3.Text);
                if (txtSemaforo1.Text != "" && txtSemaforo2.Text != "" && txtSemaforo3.Text != "")
                {
                    suma = z + y + x;
                    if (suma != 6)
                    {
                        MessageBox.Show("Las posiciones no se pueden repetir", "Poscion falsa");
                        z = int.Parse(txtSemaforo1.Text);
                        y = int.Parse(txtSemaforo2.Text);
                        x = int.Parse(txtSemaforo3.Text);
                        txtSemaforo1.Text = string.Empty;
                        txtSemaforo2.Text = string.Empty;
                        txtSemaforo3.Text = string.Empty;
                        txtSemaforo1.Focus();
                    }
                    else
                    {
                        tmrSemaforo1.Enabled = true;
                        tmrSemaforo2.Enabled = true;
                        tmrSemaforo3.Enabled = true;
                        //encender los timer 
                        tmrParpadeo.Enabled = true;
                        tmrParpadeo2.Enabled = true;
                        tmrParpadeo3.Enabled = true;
                        //aqui faltan activar los timers de los movimientos de los carros
                    }
                }
                else
                {
                    MessageBox.Show("no debe de dejar una casilla vacía", "casilla vacia");
                    txtSemaforo1.Text = string.Empty;
                    txtSemaforo2.Text = string.Empty;
                    txtSemaforo3.Text = string.Empty;
                    txtSemaforo1.Focus();
                }
            }
            catch (Exception)
            {
                txtSemaforo1.Text = string.Empty;
                txtSemaforo2.Text = string.Empty;
                txtSemaforo3.Text = string.Empty;
                txtSemaforo1.Focus();
                MessageBox.Show("no se pueden introducir letras", "tipo de dato");
            }
            
        }
        private void tmrSemaforo2_Tick(object sender, EventArgs e)
        {
			var semaforo = semaforos.Where(s => s.Id == 1).First();

			if (semaforo.IsCurrent)
			{

				if (cverdeb < 6) // 6 segundos en verde
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Verde;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					tmrRecto.Enabled = true; // Solo el carro recto avanza
					tmrCarroIzquierda.Enabled = false;
					tmrCarroDerecha.Enabled = false;

					cverdeb++;
				}
				else if (camarillob < 3) // 3 segundos en amarillo después del verde
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					tmrRecto.Enabled = false; // Detiene el carro recto
					camarillob++;
				}
				else if (crojob < 15) // 15 segundos en rojo después del amarillo
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Rojo;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					crojob++;
				}
				else
				{
					// Fin del ciclo del semáforo 2, inicia el semáforo 3
					semaforo.IsCurrent = false;
					semaforos[2].IsCurrent = true;
					reiniciarContadores();
					//tmrSemaforo2.Enabled = false;
					//tmrSemaforo3.Enabled = true;
				}
			}
        }

		private void tmrSemaforo3_Tick(object sender, EventArgs e)
		{
			var semaforo = semaforos.Where(s => s.Id == 2).First();

			if (semaforo.IsCurrent)
			{

				if (cverdec < 6) // 6 segundos en verde
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Verde;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					tmrCarroDerecha.Enabled = true; // Solo el carro derecha avanza
					tmrCarroIzquierda.Enabled = false;
					tmrRecto.Enabled = false;

					cverdec++;
				}
				else if (camarilloc < 3) // 3 segundos en amarillo después del verde
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Amarillo;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);

					tmrCarroDerecha.Enabled = false; // Detiene el carro derecha
					camarilloc++;
				}
				else if (crojoc < 15) // 15 segundos en rojo después del amarillo
				{
					serialPort1.Write(semaforo.Identifiers[3]);
					serialPort1.Write(semaforo.Identifiers[4]);
					serialPort1.Write(semaforo.Identifiers[5]);

					semaforo.SemaforoStatus = SemaforoStatus.Rojo;

					serialPort1.Write(semaforo.Identifiers[(int)semaforo.SemaforoStatus]);
					crojoc++;
				}
				else
				{
					semaforo.IsCurrent = false;
					semaforos[0].IsCurrent = true;
					// Fin del ciclo del semáforo 3, vuelve a iniciar el semáforo 1
					reiniciarContadores();
					//tmrSemaforo3.Enabled = false;
					//tmrSemaforo1.Enabled = true;
				}
			}
		}

		private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
        

        private void btnAbrirPuerto_Click_1(object sender, EventArgs e)
        {
            AbrirPuerto();
            btnAuto.Visible = true;
            btnManual.Visible = true;
            btnContinuar.Visible = true;
            btnParar.Visible = true;
            picCarretera2.Visible = true;
            picCarroIzquierda.Visible = true;
            picCarroDerecha.Visible = true;
            picCarroTrasero.Visible = true;
            picCarretera2.Enabled= true; 
            picCarroDerecha.Enabled= true;
            picCarroIzquierda.Enabled= true;
            picCarroTrasero.Enabled= true;
        }


        private void btnAuto_Click(object sender, EventArgs e)
        {

			SetInitialState();
			MessageBox.Show($"Semáforos: semáforo 1: {semaforo}, semáforo 2: {semaforo2}, semáforo 3: {semaforo3}");
			tmrSemaforo3.Enabled = true;
			tmrSemaforo2.Enabled = true;
			tmrSemaforo1.Enabled = true;
		}


		void AbrirPuerto()
        {
            //VALIDAR QUE EL COMBO BOX TENGA PUERTOS DETECTADOS
            if (cmbPuertosSeriales.Items.Count >= 1)
            {
                //verificaf que al menos se seleccione al menos un puerto
                if (cmbPuertosSeriales.SelectedIndex != -1)
                {
                    //verificar si no esta abierto el puerto serial
                    if (!serialPort1.IsOpen)
                    {
                        //se asigna el nombre del puerto seleccionado
                        serialPort1.PortName = cmbPuertosSeriales.SelectedItem.ToString();
                        //abre el puerto
                        serialPort1.Open();
                        //asigna la imagen del led apagado
                        
                        MessageBox.Show("el puerto serial se abrio correctamente", "abrir el puerto");


                    }
                    else
                    {
                        MessageBox.Show("el puerto ya se encuentra abierto", "abrir el puerto");
                    }
                }
                else
                {
                    MessageBox.Show("debes de seleccionar un puerto para abrirlo", "abrir el puerto");
                }
            }
            else
            {
                MessageBox.Show("no hay puertos seriales disponibles", "abrir el puerto");
            }
        }

        

        private void frmMenú_Load(object sender, EventArgs e)
        {
            try
            {
                // Limpiar los valores del combobox
                cmbPuertosSeriales.Items.Clear();
                // Verificar si el arreglo tiene por lo menos un valor
                if (puertosdisponibles.Length >= 1)
                {
                    // Se recorre el arreglo con los nombres de los puertos seriales detectados y los asigna al combo.
                    foreach (string puerto in puertosdisponibles)
                    {
                        // Agrega el nombre del com o puerto serial al combobox
                        cmbPuertosSeriales.Items.Add(puerto);
                    }
                }
                else
                {
                    MessageBox.Show("No se detectaron puertos seriales conectados!");
                    cmbPuertosSeriales.Text = "Sin puertos";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Verificar la conexión con el puerto serial.", "Encender/Apagar el Led!");
            }
        }
    }
}
