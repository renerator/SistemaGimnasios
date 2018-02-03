using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SistemaGimnasios.Administracion
{
    public partial class Enrrolamiento : System.Web.UI.Page
    {
        private readonly DAOGimnasios.Control.Control _control = new DAOGimnasios.Control.Control();
        private DataSet _ds = new DataSet();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack) return;
            CargaPlanes();
            //Init();
            //Start();
        }

        protected void CargaPlanes()
        {
            try
            {
                var ds = _control.CargaListadoPlanes();
                ddlPlanes.DataSource = ds;
                ddlPlanes.DataTextField = "NombrePlan";
                ddlPlanes.DataValueField = "idPlan";
                ddlPlanes.DataBind();
            }
            catch (Exception ex)
            {
                lblinformacion.Text = "Ha ocurrido un problema: " + ex.Message;
            }

        }

        protected void ddlPlanes_DataBound(object sender, EventArgs e)
        {
            ddlPlanes.Items.Insert(0, new ListItem(string.Empty, "0"));
        }

        protected void btnGrabarDatos_Click(object sender, EventArgs e)
        {
            lblinformacion.Text = "Agregando informacion al sistema";
        }

        protected virtual void Init()
        {
            try
            {
                var Capturer = new DPFP.Capture.Capture();				// Create a capture operation.

                if (null != Capturer)
                {
                    SetPrompt("¡Iniciando Captura!");
                    //Capturer.EventHandler = OnComplete();					// Subscribe for capturing events.
                }
               // else
                    //lblinfoHuella.Text = "¡No se puede iniciar la operación de captura!";


            }
            catch
            {
                //lblinfoHuella.Text = "¡No se puede iniciar la operación de captura!";
            }
        }

        protected void Start()
        {
            var Capturer = new DPFP.Capture.Capture();
            if (null != Capturer)
            {
                try
                {
                    //imgBorde.ImageUrl = "../Utilitarios/Recursos/HuellaDigital.jpg";
                    Capturer.StartCapture();
                    SetPrompt("Utilizando el lector de huellas dactilares, escanee su huella digital.");
                }
                catch
                {
                    //lblinfoHuella.Text="¡No se puede iniciar la operación de captura!";
                }
            }
        }

        protected void Stop()
        {
            var Capturer = new DPFP.Capture.Capture();
            if (null != Capturer)
            {
                try
                {
                    Capturer.StopCapture();
                }
                catch
                {
                    //lblinfoHuella.Text = "¡No se puede Terminar la operación de captura!";
                }
            }
        }
        protected virtual void Process(DPFP.Sample Sample)
        {
            //Draw fingerprint sample image.
            DrawPicture(ConvertSampleToBitmap(Sample));
        }


        #region EventHandler Members:

        public void OnComplete(object Capture, string ReaderSerialNumber, DPFP.Sample Sample)
        {
            MakeReport("La muestra de la huella digital fue capturada.");
            SetPrompt("Escanee de nuevo la misma huella digital.");
            Process(Sample);
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El dedo se retiró del lector de huellas dactilares.");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El lector de huellas dactilares fue tocado.");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El lector de huellas esta conectado.");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            MakeReport("El lector de huellas dactilares fue desconectado.");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, DPFP.Capture.CaptureFeedback CaptureFeedback)
        {
            if (CaptureFeedback == DPFP.Capture.CaptureFeedback.Good)
                MakeReport("La calidad de la muestra de la huella digital es buena.");
            else
                MakeReport("La calidad de la muestra de huellas digitales es deficiente.");
        }
        #endregion

        protected Bitmap ConvertSampleToBitmap(DPFP.Sample Sample)
        {
            DPFP.Capture.SampleConversion Convertor = new DPFP.Capture.SampleConversion();	// Create a sample convertor.
            Bitmap bitmap = null;												            // TODO: the size doesn't matter
            Convertor.ConvertToPicture(Sample, ref bitmap);									// TODO: return bitmap as a result
            return bitmap;
        }

        protected DPFP.FeatureSet ExtractFeatures(DPFP.Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();	// Create a feature extractor
            DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
            DPFP.FeatureSet features = new DPFP.FeatureSet();
            Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);			// TODO: return features as a result?
            if (feedback == DPFP.Capture.CaptureFeedback.Good)
                return features;
            else
                return null;
        }

        protected void SetStatus(string status)
        {
            //lblinfoHuella.Text += status + "<br />";
        }

        protected void SetPrompt(string prompt)
        {
            //lblinfoHuella.Text += prompt + "<br />";
        }
        protected void MakeReport(string message)
        {
            //lblinfoHuella.Text += message + "<br />";
        }

        private void DrawPicture(Bitmap bitmap)
        {
            //imagenHuella.Visible = true;
            //imgBorde.ImageUrl = new Bitmap(bitmap, imgBorde.Size);	// fit the image into the picture box
        }
    }
}