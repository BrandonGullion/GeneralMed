using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using Xceed.Document.NET;
using Xceed.Words.NET;
using System.Diagnostics;
using System.Windows;

namespace GeneralMed2._0
{
    public class DocumentCreator
    {
        // Getting the values from the selected patient 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public string Updated { get; set; }
        public ObservableCollection<PatientDrugModel> PatientDrugList { get; set; }



        public DocumentCreator(string firstName, string lastName, string dob, string address, string updated, ObservableCollection<PatientDrugModel> patientDrugList)
        {
            // Sets the selected patient information to be exported onto document 
            FirstName = firstName;
            LastName = lastName;
            DOB = dob;
            Address = address;
            Updated = updated;

            // Passing the drug list through 
            PatientDrugList = patientDrugList;
        }

        public void CreateDocument()
        {
            #region Directory Information

            // Set up the save folder if it is not present 
            var currentDirectory = Directory.GetCurrentDirectory();
            var saveFolder = "ExportedDrugLists";
            var saveDirectory = Path.Combine(currentDirectory, saveFolder);

            // Create save folder 
            Directory.CreateDirectory(saveDirectory);

            // Setting up document naming 
            var fileName = $"{LastName}-{FirstName}.docx";
            var saveLocation = Path.Combine(saveDirectory, fileName);

            // Checking if the file currently exists
            if (File.Exists(saveLocation))
            {
                // If file exists prompt a warning that it will be over written 
                MessageBoxButton button = MessageBoxButton.YesNo;
                MessageBoxResult result = MessageBox.Show("Would you like to overwrite?", "Current patient file already exists", button);

                // If selected no, then leave loop and method 
                if (result == MessageBoxResult.No)
                    return;
            }

            var document = DocX.Create(saveLocation);

            #endregion

            #region Patient Information

            document.InsertParagraph($"Patient Name : {FirstName} {LastName}");
            document.InsertParagraph($"Date of Birth : {DOB}");
            document.InsertParagraph($"Address/Room : {Address}");
            document.InsertParagraph($"Last Updated : {Updated}\n\n");

            #endregion

            #region DrugListInformation

            var rowNum = PatientDrugList.Count;

            Table t = document.AddTable(rowNum + 1, 4);
            t.Design = TableDesign.LightListAccent5;

            int i = 1;

            t.Rows[0].Cells[0].Paragraphs.First().Append("Drug Name:");
            t.Rows[0].Cells[1].Paragraphs.First().Append("Strength:");
            t.Rows[0].Cells[2].Paragraphs.First().Append("General Use:");
            t.Rows[0].Cells[3].Paragraphs.First().Append("Last Updated:");

            foreach (var drug in PatientDrugList)
            {
                t.Rows[i].Cells[0].Paragraphs.First().Append(drug.DrugName);
                t.Rows[i].Cells[1].Paragraphs.First().Append(drug.DrugStrength);
                t.Rows[i].Cells[2].Paragraphs.First().Append(drug.GeneralPurpose);
                t.Rows[i].Cells[3].Paragraphs.First().Append(drug.LastUpdate);

                i++;
            }

            document.InsertTable(t);
            #endregion

            document.Save();
            Process.Start(saveLocation);
        }
    }
}
