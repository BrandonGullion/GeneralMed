using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;

namespace GeneralMed2._0.ViewModels
{
    public class AddGeneralUseWindowViewModel : BasePropertyChanged
    {
        #region Properties

        public GeneralUseModel localSelectedGeneralUse { get; set; }

        private string localGeneralUse;
        public string LocalGeneralUse 
        {
            get { return localGeneralUse; }
            set { localGeneralUse = value; OnPropertyChanged(nameof(LocalGeneralUse)); }
        }

        private string generalUseGeneralUse;

        public string GeneralUseGeneralUse
        {
            get { return generalUseGeneralUse; }
            set { generalUseGeneralUse = value; OnPropertyChanged(nameof(GeneralUseGeneralUse)); }
        }


        private string generalUseString;

        public string GeneralUseString
        {
            get { return generalUseString; }
            set { generalUseString = value; OnPropertyChanged(nameof(GeneralUseString));  SaveGeneralUseCommand.RaiseCanExecuteChanged(); }
        }

        private List<GeneralUseModel> generalUseList;

        public List<GeneralUseModel> GeneralUseList
        {
            get { return generalUseList; }
            set { generalUseList = value; OnPropertyChanged(nameof(GeneralUseList)); }

        }

        public Action CloseWindowAction { get; set; }

        private GeneralUseModel generalUse;

        public GeneralUseModel GeneralUse
        {
            get { return generalUse; }
            set { generalUse = value; OnPropertyChanged(nameof(GeneralUse)); SaveGeneralUseCommand.RaiseCanExecuteChanged(); }
        }

        private GeneralUseModel selectedGeneralUse;

        public GeneralUseModel SelectedGeneralUse
        {
            get { return selectedGeneralUse; }
            set 
            { 
                selectedGeneralUse = value;
                OnPropertyChanged(nameof(SelectedGeneralUse));

                // Saves a local version of the selected model
                if(SelectedGeneralUse != null)
                {
                    localSelectedGeneralUse = SelectedGeneralUse;
                    localGeneralUse = SelectedGeneralUse.GeneralUse;
                }
                // Saves a local variable fo the selected model general use 
                DeleteSelectedPurposeCommand.RaiseCanExecuteChanged();
                UpdateSelectedPurposeCommand.RaiseCanExecuteChanged();
            }
        }


        #endregion


        #region Commands

        public RelayCommand SaveGeneralUseCommand { get; set; }
        public RelayCommand DeleteSelectedPurposeCommand { get; set; }
        public RelayCommand UpdateSelectedPurposeCommand { get; set; }

        #endregion

        #region Constructor


        public AddGeneralUseWindowViewModel()
        {
            // Generate the list to add the value to 
            GeneralUseList = new List<GeneralUseModel>();

            UpdateSelectedPurposeCommand = new RelayCommand(() => UpdateSelectedPurpose(), () => CheckSelectedPurpose());
            SaveGeneralUseCommand = new RelayCommand(() => Save(), () => CheckTextBox());
            DeleteSelectedPurposeCommand = new RelayCommand(() => DeleteSelectedPurpose(), () => CheckSelectedPurpose());

            PopulateGeneralUseList();

        }

        #endregion

        #region Methods

        public void PopulateGeneralUseList()
        {
            GeneralUseList = DatabaseHelper.ReadGeneralUseDB(GeneralUseList);
        }

        public void Save()
        {
            // This should add the general use to the list
            DatabaseHelper.AddGeneralUse(GeneralUseString);
            PopulateGeneralUseList();
        }

        public bool CheckTextBox()
        {
            if (generalUseString != null)
                return true;
            else
                return false;
        }

        public void UpdateSelectedPurpose()
        {
            DatabaseHelper.UpdateGeneralUse(localSelectedGeneralUse, localGeneralUse);
            PopulateGeneralUseList();
        }

        public void DeleteSelectedPurpose()
        {
            DatabaseHelper.DeleteGeneralUse(SelectedGeneralUse);
            PopulateGeneralUseList();
        }

        public bool CheckSelectedPurpose()
        {
            if (SelectedGeneralUse != null)
                return true;
            else
                return false;
        }

        #endregion

    }
}
