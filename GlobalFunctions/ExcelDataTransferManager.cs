using MAUI_SPM.DataModels;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronXL;
using IronXL.Options;
using Remotion.Linq.Parsing.Structure.IntermediateModel;

namespace SPM_WINFM.GlobalFunctions
{
    internal class ExcelDataTransferManager
    {
        public ExcelDataTransferManager(Models.TrainInformationModel trainInformationModel,
                                        List<Models.BrakingPatternModelLists> bft_brakingPatterlList,
                                        List<Models.BrakingPatternModelLists> bpt_brakingPatterlList,
                                        List<Models.RunPlotterListModel> runplotterlist,
                                        List<Models.BrakingPatternModelLists> stoppagesPlotterList)
        {
            String Filename = String.Concat(_trainInformationModel.Get_LocoPilotName, "_",
                                             _trainInformationModel.Get_TrainNumber, "_",
                                             _trainInformationModel.Get_AnalysedSection, "_",
                                             _trainInformationModel.Get_QueryStartFromTime).ToString();

            _sourceFileName = Path.Combine(_sourceDirectary, Filename);

            _trainInformationModel = trainInformationModel;
            _bft_BrakingPattern_Lists = bft_brakingPatterlList;
            _bpt_BrakingPattern_Lists = bpt_brakingPatterlList;
            _runPlottingList = runplotterlist;
            _stoppagesPlottingList = stoppagesPlotterList;

        }

        // Transfer Properties
        private String _sourceDirectary { get { return Properties.Settings.Default["SourceDirectory"]?.ToString(); } }
        private String _sourceFileName { get; set; }
        private Models.TrainInformationModel _trainInformationModel { get; set; }
        private List<Models.BrakingPatternModelLists> _bft_BrakingPattern_Lists { get; set; }
        private List<Models.BrakingPatternModelLists> _bpt_BrakingPattern_Lists { get; set; }

        private List<Models.RunPlotterListModel> _runPlottingList { get; set; }
        private List<Models.BrakingPatternModelLists> _stoppagesPlottingList { get; set; }

        private WorkBook SourceBook = WorkBook.Create(ExcelFileFormat.XLSX);

        private void ConfigureWorkBook()
        {
            SourceBook.DefaultWorkSheet.Name = "OutPut";
            SourceBook.CreateWorkSheet("BrakeTest");
            SourceBook.CreateWorkSheet("RunPlot");
            SourceBook.CreateWorkSheet("StopPattern");

        }
    }
}
