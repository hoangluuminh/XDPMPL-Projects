﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.ComponentModel.DataAnnotations;
using TourDuLich_GUI.Models;
using System.Data.Entity;
using TourDuLich_GUI.BUS;
using System.Collections.ObjectModel;

namespace TourDuLich_GUI
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public List<Tour> tours = new List<Tour>()
            {
                new Tour() {
                    ID = 1,
                    Name = "Saigon - Hanoi",
                    Description = "Wow",
                    PriceRef = 300000
                },
                new Tour() {
                    ID = 2,
                    Name = "Saigon - Da Nang",
                    Description = "wowwww",
                    PriceRef = 400000
                },
                new Tour() {
                    ID = 3,
                    Name = "Saigon - Da Lat",
                    Description = "cold place",
                    PriceRef = 200000
                },
            };
        public List<Destination> destinations = new List<Destination>()
            {
                new Destination() {
                    ID = 1,
                    Name = "Ha Long Bay"
                },
                new Destination() {
                    ID = 2,
                    Name = "Pho co Hoi An"
                },
                new Destination() {
                    ID = 3,
                    Name = "Tiem banh Coi Xay Gio"
                },
            };
        public List<TourType> tourTypes = new List<TourType>()
        {
            new TourType()
            {
                ID = 1,
                Name = "Du lịch di động"
            },
            new TourType()
            {
                ID = 2,
                Name = "Du lịch kết hợp nghề nghiệp"
            },
            new TourType()
            {
                ID = 3,
                Name = "Du lịch xã hội và gia đình"
            },
        };

        public MainView()
        {
            InitializeComponent();

            /*            dataSource = GetDataSource();
                        gridControl.DataSource = dataSource;
                        bsiListCount.Caption = $"{dataSource.Count} items";
            */

            InitializeDataSources();
        }

        private async void InitializeDataSources()
        {
            gridControl.DataSource = await TourBUS.GetAll();
        }

        void bbiPrintPreview_ItemClick(object sender, ItemClickEventArgs e)
        {
            gridControl.ShowRibbonPrintPreview();
        }
        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditTourView editTourView = new EditTourView();
            editTourView.ShowDialog(this);

            Console.WriteLine("Completed.");
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            {
                Tour selectedTour = (Tour)gridView.GetFocusedRow();
                Console.WriteLine("Data: " + (selectedTour.Name));
                EditTourView editTourView = new EditTourView(selectedTour);
                editTourView.ShowDialog(this);

                Console.WriteLine("Completed.");
            }
        }
    }
}