using Prism.Mvvm;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;

namespace TreasurerHelper.Cashbook.ViewModels
{
    public class CashbookViewModel : BindableBase
    {
        private string _inputData;
        public string InputData
        {
            get { return _inputData; }
            set { SetProperty(ref _inputData, value); }
        }

        private string _message;
        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value);
            }
        }

        private bool HaveData()
        {
            return !string.IsNullOrEmpty(InputData);
        }
        private bool NoData()
        {
            return string.IsNullOrEmpty(InputData);
        }

        public InteractionRequest<INotification> FileOpenRequest { get; set; }
        public DelegateCommand FileOpenCommand { get; private set; } 
        public DelegateCommand FileSaveCommand { get; private set; }
        public DelegateCommand CsvImportCommand { get; private set; }
        public DelegateCommand PrintPreviewCommand { get; private set; }
        public DelegateCommand PrintCommand { get; private set; }


        public CashbookViewModel()
        {
            FileOpenRequest = new InteractionRequest<INotification>();
            FileOpenCommand = new DelegateCommand(FileOpen, NoData).ObservesProperty(() => InputData);

            FileSaveCommand = new DelegateCommand(FileSave, HaveData).ObservesProperty(() => InputData);
            CsvImportCommand = new DelegateCommand(CsvImport, NoData).ObservesProperty(() => InputData);
            PrintPreviewCommand = new DelegateCommand(PrintPreview, HaveData).ObservesProperty(() => InputData);
            PrintCommand = new DelegateCommand(Print, HaveData).ObservesProperty(() => InputData); 
        }

        private void FileOpen()
        {
            FileOpenRequest.Raise(new Notification { Title = "Custom Popup", Content = "Custom Popup Message " }, r => Message = "File Open Command");
        }

        private void FileSave()
        {
            Message = "File Save Command";

        }

        private void CsvImport()
        {
            Message = "Csv Import Command";
        }

        private void PrintPreview()
        {
            Message = "PrintPreview Command";
        }

        private void Print()
        {
            Message = "Print Command";
        }
    }
}
