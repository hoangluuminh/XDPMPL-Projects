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
using TourDuLich_GUI.BUS;
using System.Data.Entity;
using System.Collections.ObjectModel;

namespace TourDuLich_GUI.GUI
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        enum Page
        {
            Tours,
            TourGroups
        }

        public MainView()
        {
            InitializeComponent();
            ConfigureControls();
            InitializeDataSources();
        }

        private void ConfigureControls()
        {
            gridView_Tours.OptionsBehavior.Editable = false;
            gridView_TourGroups.OptionsBehavior.Editable = false;
        }

        private Page getCurrentPage()
        {
            Page curPage = Page.Tours;
            int tabIndex = xtraTabControl_Tours.SelectedTabPageIndex;
            switch (tabIndex)
            {
                case 0:
                    {
                        curPage = Page.Tours; break;
                    }
                case 1:
                    {
                        curPage = Page.TourGroups; break;
                    }
            }

            return curPage;
        }

        private void InitializeDataSources()
        {   
            switch (getCurrentPage())
            {
                case Page.Tours:
                    {
                        InitializeDataSources_Tours();
                        break;
                    }
                case Page.TourGroups:
                    {
                        InitializeDataSources_TourGroups();
                        break;
                    }
            }
        }

        private void InitializeDataSources_Tours()
        {
            // TODO: Remove ASYNC

            // Prefetch UI changes
            gridView_Tours.ShowLoadingPanel();

            // Data fetch
            BindingList<Tour> list = new BindingList<Tour>(
                Tour.GetAll()
            );
            //Mapping tour price
            foreach( Tour tour in list)
            {
                tour.CurrentPrice = Tour.GetTourPriceOrPriceRef(tour.ID, DateTime.Now);
            }

            // UI changes
            gridView_Tours.HideLoadingPanel();
            gridControl_Tours.DataSource = list;
            /*            gridControl_Tours.DataMember.
            */
            gridControl_Tours.RefreshDataSource();
            bsiListCount.Caption = $"{list.Count} items";
        }

        private void InitializeDataSources_TourGroups()
        {
            // Data fetch
            BindingList<TourGroup> list = new BindingList<TourGroup>(
                TourGroup.GetAll()
            );

            // UI changes
            gridControl_TourGroups.DataSource = list;
            gridControl_TourGroups.RefreshDataSource();
            bsiListCount.Caption = $"{list.Count} items";
        }

        // Event Handlers

        private void handleNewTour()
        {
            EditTourView editTourView = new EditTourView();
            editTourView.ShowDialog(this);
        }

        private void handleEditTour()
        {
            Tour selectedTour = (Tour)gridView_Tours.GetFocusedRow();

            if (selectedTour == null)
            {
                return;
            }

            EditTourView editTourView = new EditTourView(selectedTour);
            editTourView.ShowDialog(this);
        }

        private void handleDeleteTour()
        {
            Tour selectedTour = (Tour)gridView_Tours.GetFocusedRow();

            if (selectedTour == null)
            {
                return;
            }

            Tour.DeleteOne(selectedTour);
        }

        private void handleNewTourGroup()
        {
            EditTourGroupView editTourGroupView = new EditTourGroupView();
            editTourGroupView.ShowDialog(this);
        }

        private void handleEditTourGroup()
        {
            TourGroup selectedTourGroup = (TourGroup)gridView_TourGroups.GetFocusedRow();

            if (selectedTourGroup == null)
            {
                return;
            }

            EditTourGroupView editTourGroupView = new EditTourGroupView(selectedTourGroup);
            editTourGroupView.ShowDialog(this);
        }

        private void handleDeleteTourGroup( ) { 
            TourGroup selectedTourGroup = (TourGroup)gridView_TourGroups.GetFocusedRow();

            if (selectedTourGroup == null) {
                return;
            }

            TourGroup.DeleteOne(selectedTourGroup.ID);
        }

        // Events

        private void bbiNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (getCurrentPage())
            {
                case Page.Tours:
                    {
                        handleNewTour();
                        break;
                    }
                case Page.TourGroups:
                    {
                        handleNewTourGroup();
                        break;
                    }
            }

            // Post-Disposal of Dialog
            InitializeDataSources();
        }

        private void bbiEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (getCurrentPage())
            {
                case Page.Tours:
                    {
                        handleEditTour();
                        break;
                    }
                case Page.TourGroups:
                    {
                        handleEditTourGroup();
                        break;
                    }
            }

            // Post-Disposal of Dialog
            InitializeDataSources();
        }

        private void bbiDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            switch (getCurrentPage()) {
                case Page.Tours: {
                        DialogResult res = MessageBox.Show("Bạn chắc chắn muốn xóa tour du lịch này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            handleDeleteTour();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
                case Page.TourGroups: {
                        DialogResult res = MessageBox.Show("Bạn chắc chắn muốn xóa đoàn tour du lịch này?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                        if (res == DialogResult.OK)
                        {
                            handleDeleteTourGroup();
                            MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        break;
                    }
            }

            // Refresh
            InitializeDataSources();
        }

        private void gridView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            object selectedItem = null;
            switch (getCurrentPage())
            {
                case Page.Tours:
                    {
                        selectedItem = gridView_Tours.GetFocusedRow();
                        break;
                    }
                case Page.TourGroups:
                    {
                        selectedItem = gridView_Tours.GetFocusedRow();
                        break;
                    }
            }
            bool selectedExists = selectedItem != null;

            bbiEdit.Enabled = selectedExists;
            bbiDelete.Enabled = selectedExists;
        }

        private void xtraTabControl_Tours_SelectedPageChanged(object sender, DevExpress.XtraTab.TabPageChangedEventArgs e)
        {
            InitializeDataSources();
        }
    }
}