using GalaSoft.MvvmLight.Command;
using GeneralMed2._0.Models;
using System;
using System.Collections.Generic;
using System.Windows.Controls.Primitives;

namespace GeneralMed2._0
{
    public class AddDrugWindowViewModel : BasePropertyChanged
    {
        #region Properties

        private DrugModel selectedUpdate;

        public DrugModel SelectedUpdate
        {
            get { return selectedUpdate; }
            set 
            { 
                selectedUpdate = value; 
                OnPropertyChanged(nameof(SelectedUpdate)); 
                DeleteSelectedDrugCommand.RaiseCanExecuteChanged();
                UpdateSelectedDrugCommand.RaiseCanExecuteChanged();
            }
        }

        public Action CloseAction { get; set; }

        private string drugName;

        public string DrugName
        {
            get { return drugName; }
            set { drugName = value; OnPropertyChanged(nameof(DrugName)); SaveNewDrugCommand.RaiseCanExecuteChanged(); }
        }

        private string strength;

        public string Strength
        {
            get { return strength; }
            set { strength = value; OnPropertyChanged(nameof(Strength)); SaveNewDrugCommand.RaiseCanExecuteChanged(); }
        }

        private string generalUse;

        public string GeneralUse
        {
            get { return generalUse; }
            set { generalUse = value; OnPropertyChanged(nameof(Strength)); SaveNewDrugCommand.RaiseCanExecuteChanged(); }
        }

        private GeneralUseModel leftGeneralUse;

        public GeneralUseModel LeftGeneralUse
        {
            get { return leftGeneralUse; }
            set { leftGeneralUse = value; OnPropertyChanged(nameof(LeftGeneralUse)); SaveNewDrugCommand.RaiseCanExecuteChanged(); }
        }

        private GeneralUseModel rightGeneralUse;

        public GeneralUseModel RightGeneralUse
        {
            get { return rightGeneralUse; }
            set { rightGeneralUse = value; OnPropertyChanged(nameof(RightGeneralUse)); UpdateSelectedDrugCommand.RaiseCanExecuteChanged(); }
        }


        private List<DrugModel> drugModelList;

        public List<DrugModel> DrugModelList
        {
            get { return drugModelList; }
            set { drugModelList = value; OnPropertyChanged(nameof(DrugModelList)); }
        }

        private List<GeneralUseModel> generalUseList;

        public List<GeneralUseModel> GeneralUseList
        {
            get { return generalUseList; }
            set { generalUseList = value; OnPropertyChanged(nameof(GeneralUseList)); }
        }

        #endregion

        #region Commands
        public RelayCommand SaveNewDrugCommand { get; set; }

        public RelayCommand DeleteSelectedDrugCommand { get; set; }

        public RelayCommand UpdateSelectedDrugCommand { get; set; }



        #endregion

        #region Constructor


        public AddDrugWindowViewModel()
        {
            // Lists 

            DrugModelList = new List<DrugModel>();

            GeneralUseList = new List<GeneralUseModel>();

            // Commands
            SaveNewDrugCommand = new RelayCommand(() => SaveDrug(), () => CheckSaveDrug());
            DeleteSelectedDrugCommand = new RelayCommand(() => DeleteSelectedDrug(), () => CheckIfDrugSelected());
            UpdateSelectedDrugCommand = new RelayCommand(() => UpdateSelectedDrug(), () => CheckUpdateSelected());


            // Methods 
            PopulateGeneralUseList();
            PopulateDrugList();
        }

        #endregion

        #region Methods


        // <> --- Save Drug Methods --- <> 

        public bool CheckSaveDrug()
        {
            if (!string.IsNullOrWhiteSpace(DrugName) && LeftGeneralUse != null)
                return true;

            else
                return false;
        }

        public void SaveDrug()
        {
            DatabaseHelper.AddDrug(DrugName, LeftGeneralUse);
            CloseAction();
        }

        // <> --- Populate Lists --- <> 


        public void PopulateGeneralUseList()
        {
            GeneralUseList = DatabaseHelper.ReadGeneralUseDB(GeneralUseList);
        }

        public void PopulateDrugList()
        {
            DrugModelList = DatabaseHelper.ReadDrugDB(DrugModelList);
        }

        // <> --- Delete Drug Methods --- <> 

        public void DeleteSelectedDrug()
        {
            DatabaseHelper.DeleteDrugFromDB(SelectedUpdate);
            SelectedUpdate = null;
            RightGeneralUse = null;
            PopulateDrugList();
        }

        public bool CheckIfDrugSelected()
        {
            if (SelectedUpdate != null)
                return true;
            else
                return false;
        }

        // <> --- Update Drug Methods --- <> 

        public void UpdateSelectedDrug()
        {
            DatabaseHelper.UpdateDrug(SelectedUpdate, SelectedUpdate.DrugName, RightGeneralUse);
            PopulateDrugList();
        }

        public bool CheckUpdateSelected()
        {
            if (SelectedUpdate != null && RightGeneralUse != null)
                return true;
            else
                return false;
        }


        #endregion
    }
}
