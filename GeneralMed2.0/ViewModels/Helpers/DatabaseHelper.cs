using GeneralMed2._0.Models;
using GeneralMed2._0.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace GeneralMed2._0
{
    public class DatabaseHelper
    {

        static string databaseName = "Patient.db";
        static string drugDatabase = "Drugs.db";
        static string generalUseDatabase = "GeneralUse.db";
        static string patientDrugModelDatabase = "PatientDrug.db";
        static string folderPath = Environment.CurrentDirectory;

        // Patient DB path
        public static string databasePath = System.IO.Path.Combine(folderPath, databaseName);

        // Drug DB path
        public static string drugDatabasePath = System.IO.Path.Combine(folderPath, drugDatabase);

        public static string generalUseDatabasePath = System.IO.Path.Combine(folderPath, generalUseDatabase);

        public static string patientDrugModelDatabasePath = System.IO.Path.Combine(folderPath, patientDrugModelDatabase);


        #region Methods

        /// <summary>
        /// Populate the patient list for the program 
        /// </summary>
        /// <param name="list">the list that will be passed in from the view model</param>

        #region DrugDB

        public static List<DrugModel> ReadDrugDB(List<DrugModel> list)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(drugDatabasePath))
            {
                // Create table/ check for table so program does not crash 
                connection.CreateTable<DrugModel>();
                list = (connection.Table<DrugModel>().ToList()).OrderBy(d => d.DrugName).ToList();
            }

            return list;
        }
        public static void DeleteDrugFromDB(DrugModel selectedDrug)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(drugDatabasePath))
            {
                // Create table/ check for table so program does not crash 
                connection.CreateTable<DrugModel>();

                // Delete the currently selected patient 
                connection.Delete(selectedDrug);
            }
        }
        public static void AddDrug(string drugName, GeneralUseModel generalPurpose)
        {
            DrugModel newDrug = new DrugModel();
            newDrug.DrugName = drugName;
            newDrug.GeneralUse = generalPurpose.GeneralUse;
            newDrug.DateAdded = DateTime.Now;
            newDrug.LastUpdated = DateTime.Now;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(drugDatabasePath))
            {
                connection.CreateTable<DrugModel>();
                connection.Insert(newDrug);
            }
        }
        public static void UpdateDrug(DrugModel selectedDrugModel, string drugName, GeneralUseModel generalUse)
        {
            selectedDrugModel.DrugName = drugName;
            selectedDrugModel.GeneralUse = generalUse.GeneralUse;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(drugDatabasePath))
            {
                connection.CreateTable<DrugModel>();
                connection.Update(selectedDrugModel);
            }
        }

        #endregion

        #region PatientDB
        public static void ReadDB(List<PatientModel> list)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(databasePath))
            {
                // Create table/ check for table so program does not crash 
                connection.CreateTable<PatientModel>();
                list = (connection.Table<PatientModel>().ToList()).OrderBy(p => p.LastName).ToList();
            }
        }
        public static void DeletePatientFromDB(PatientModel selectedPatient)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(databasePath))
            {
                // Create table/ check for table so program does not crash 
                connection.CreateTable<PatientModel>();

                // Delete the currently selected patient 
                connection.Delete(selectedPatient);
            }

            MainWindow.AppWindow.DisplayPageFrame.Content = new PatientSearchPage();
        }
        public static void UpdatePatient(PatientModel selectedPatient, string firstName, string lastName, string dOB, string address)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(databasePath))
            {
                // Create table/ check for table so program does not crash 
                connection.CreateTable<PatientModel>();

                // Check for any null values 
                if (firstName == null || lastName == null || dOB == null || address == null)
                    MessageBox.Show("Please Fill all fields");

                else
                {
                    // Set the according values that will update the Db 
                    selectedPatient.FirstName = firstName;
                    selectedPatient.LastName = lastName;
                    selectedPatient.DOB = dOB;
                    selectedPatient.Address = address;
                    selectedPatient.LastUpdate = DateTime.Now.ToString("MMMM dd, yyyy");

                    // Delete the currently selected patient 
                    connection.Update(selectedPatient);
                }

                // Refresh the page to show the changes 
                MainWindow.AppWindow.DisplayPageFrame.Content = new PatientSearchPage();
            }
        }

        #endregion

        #region GeneralUseDB

        public static List<GeneralUseModel> ReadGeneralUseDB(List<GeneralUseModel> list)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(generalUseDatabasePath))
            {
                connection.CreateTable<GeneralUseModel>();
                list = (connection.Table<GeneralUseModel>().ToList().OrderBy(g => g.GeneralUse).ToList());
            }

            return list;
        }

        public static void AddGeneralUse(string generalUseString)
        {
            GeneralUseModel model = new GeneralUseModel();

            model.GeneralUse = generalUseString;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(generalUseDatabasePath))
            {
                connection.CreateTable<GeneralUseModel>();
                connection.Insert(model);
            }
        }

        public static void UpdateGeneralUse(GeneralUseModel selectedGeneralUseModel, string generalUse)
        {
            // Update the general use of the selected general use model 
            selectedGeneralUseModel.GeneralUse = generalUse;

            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(generalUseDatabasePath))
            {
                connection.CreateTable<GeneralUseModel>();
                connection.Update(selectedGeneralUseModel);
            }
        }

        public static void DeleteGeneralUse(GeneralUseModel generalUseModel)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(generalUseDatabasePath))
            {
                connection.CreateTable<GeneralUseModel>();
                connection.Delete(generalUseModel);
            }
        }

        #endregion

        #region PatientDrugDB

        public static List<PatientDrugModel> ReadPatientDrugModelDB(List<PatientDrugModel> list)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(patientDrugModelDatabasePath))
            {
                connection.CreateTable<PatientDrugModel>();
                list = (connection.Table<PatientDrugModel>().ToList()).OrderBy(p => p.Id).ToList();
            }

            return list;
        } 

        public static void AddPatientDrugModel(PatientModel patientModel, DrugModel drugModel, string desiredStrength)
        {
            // Explicitly setting the informationt that will be sent to the server 
            PatientDrugModel patientDrugModel = new PatientDrugModel();
            patientDrugModel.DrugName = drugModel.DrugName;
            patientDrugModel.GeneralPurpose = drugModel.GeneralUse;
            patientDrugModel.DateAddedToProfile = DateTime.Now.ToString("MMMM dd, yyyy");
            patientDrugModel.LastUpdate = DateTime.Now.ToString("MMMM dd, yyyyy");
            patientDrugModel.PatientId = patientModel.Id;
            patientDrugModel.DrugStrength = desiredStrength;


            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(patientDrugModelDatabasePath))
            {
                connection.CreateTable<PatientDrugModel>();
                connection.Insert(patientDrugModel);
            }
        }

        public static void DeletePatientDrugModel(PatientDrugModel patientDrugModel)
        {
            using (SQLite.SQLiteConnection connection = new SQLite.SQLiteConnection(patientDrugModelDatabasePath))
            {
                connection.CreateTable<PatientDrugModel>();
                connection.Delete(patientDrugModel);
            }
        }

        #endregion

        #endregion
    }
}
