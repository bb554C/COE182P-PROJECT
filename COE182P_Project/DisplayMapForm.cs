using COE182P_Project.Classes;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace COE182P_Project
{
    public partial class DisplayMapForm : Form
    {
        public DisplayMapForm()
        {
            InitializeComponent();
        }

        private void DisplayMap_Load(object sender, EventArgs e)
        {
            gMapControl.MapProvider = GoogleMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerAndCache;
            gMapControl.Zoom = 15;
            gMapControl.Position = new PointLatLng(14.59039470768, 120.975780487061);
            Reload();
            //sampleList();
        }
        private void Reload()
        {
            gMapControl.Overlays.Clear();
            GMapOverlay markers = new GMapOverlay("markers");
            setProgressBarValues();
            int loadingCounter = 1;
            textBoxUnderInvestigation.Text = PatientClass.CountUnderInvestigation().ToString();
            progressBarReload(loadingCounter++);
            textBoxActiveSerious.Text = PatientClass.CountActiveSerious().ToString();
            progressBarReload(loadingCounter++);
            textBoxActiveMild.Text = PatientClass.CountActiveMild().ToString();
            progressBarReload(loadingCounter++);
            textBoxClosedRecovered.Text = PatientClass.CountRecovered().ToString();
            progressBarReload(loadingCounter++);
            textBoxClosedDeceased.Text = PatientClass.CountDeceased().ToString();
            progressBarReload(loadingCounter++);
            textBoxTotalActive.Text = (int.Parse(textBoxActiveMild.Text) + int.Parse(textBoxActiveSerious.Text)).ToString();
            progressBarReload(loadingCounter++);
            textBoxTotalClosed.Text = (int.Parse(textBoxClosedRecovered.Text) + int.Parse(textBoxClosedDeceased.Text)).ToString();
            progressBarReload(loadingCounter++);
            textBoxTotal.Text = (int.Parse(textBoxTotalActive.Text) + int.Parse(textBoxTotalClosed.Text)).ToString();
            progressBarReload(loadingCounter++);
            if (checkedListBox1.GetItemChecked(0))
            {
                List<PatientClass.PatientList> PL = new List<PatientClass.PatientList>();
                PL = PatientClass.GetPatientListCoords(0);
                populateMap(GMarkerGoogleType.blue_small, markers, PL);
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                List<PatientClass.PatientList> PL = new List<PatientClass.PatientList>();
                PL = PatientClass.GetPatientListCoords(1);
                populateMap(GMarkerGoogleType.red_small, markers, PL);
            }
            if (checkedListBox1.GetItemChecked(2))
            {
                List<PatientClass.PatientList> PL = new List<PatientClass.PatientList>();
                PL = PatientClass.GetPatientListCoords(2);
                populateMap(GMarkerGoogleType.yellow_small, markers, PL);
            }
            if (checkedListBox1.GetItemChecked(3))
            {
                List<PatientClass.PatientList> PL = new List<PatientClass.PatientList>();
                PL = PatientClass.GetPatientListCoords(3);
                populateMap(GMarkerGoogleType.green_small, markers, PL);
            }
            if (checkedListBox1.GetItemChecked(4))
            {
                List<PatientClass.PatientList> PL = new List<PatientClass.PatientList>();
                PL = PatientClass.GetPatientListCoords(4);
                populateMap(GMarkerGoogleType.black_small, markers, PL);
            }
        }
        private void progressBarReload(int counter)
        {
            progressBar1.Value = counter;
        }
        private void setProgressBarValues()
        {
            progressBar1.Value = 0;
            progressBar1.Maximum = 8;
            if (checkedListBox1.GetItemChecked(0))
            {
                progressBar1.Maximum = progressBar1.Maximum + PatientClass.CountUnderInvestigation();
            }
            if (checkedListBox1.GetItemChecked(1))
            {
                progressBar1.Maximum = progressBar1.Maximum + PatientClass.CountActiveSerious();
            }
            if (checkedListBox1.GetItemChecked(2))
            {
                progressBar1.Maximum = progressBar1.Maximum + PatientClass.CountActiveMild();
            }
            if (checkedListBox1.GetItemChecked(3))
            {
                progressBar1.Maximum = progressBar1.Maximum + PatientClass.CountRecovered();
            }
            if (checkedListBox1.GetItemChecked(4))
            {
                progressBar1.Maximum = progressBar1.Maximum + PatientClass.CountDeceased();
            }
        }
        private void populateMap(GMarkerGoogleType GMGT, GMapOverlay markers, List<PatientClass.PatientList> PL)
        {
            foreach (PatientClass.PatientList tempPL in PL)
            {
                GMapMarker markerCoord = new GMarkerGoogle(new PointLatLng(tempPL.Latitude, tempPL.Longitude), GMGT);
                markerCoord.ToolTipText = "Patient ID: " + tempPL.PatientID;
                markers.Markers.Add(markerCoord);
                progressBar1.Value = progressBar1.Value + 1;
            }
            gMapControl.Overlays.Add(markers);
            int zoom = (int)gMapControl.Zoom;
            gMapControl.Zoom = 10;
            gMapControl.Zoom = zoom;
        }
        private void buttonReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
    }
}
