using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Ado.Net._3.Hw.Disconected_Type
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
          
        }
      public  static void CreateTable()
        {
            //1 table TrackEvaluationPart

            #region 1table

            DataSet Library = new DataSet("Library");
            DataTable trackEvaluationPart = new DataTable("TrackEvaluationPart");
            Library.Tables.Add(trackEvaluationPart);

            //intEvaluationPartId колонка primary
            DataColumn intEvaluationPartId = new DataColumn("intEvaluationPartId", typeof(int));
            intEvaluationPartId.Unique = true;
            intEvaluationPartId.AllowDBNull = false;
            intEvaluationPartId.AutoIncrement = true;
            intEvaluationPartId.AutoIncrementSeed = 1;
            intEvaluationPartId.AutoIncrementStep = 1;


            DataColumn intEvalutionId = new DataColumn("intEvalutionId", typeof(int));
            intEvalutionId.AllowDBNull = true;

            DataColumn intMasterPartId = new DataColumn("intMasterPartId", typeof(int));
            intMasterPartId.AllowDBNull = true;

            DataColumn floatQuantity = new DataColumn("floatQuantity", typeof(float));
            floatQuantity.AllowDBNull = true;

            DataColumn floatUnitCostTrack = new DataColumn("floatUnitCostTrack", typeof(float));
            floatUnitCostTrack.AllowDBNull = true;

            DataColumn floatUnitCostAvia = new DataColumn("floatUnitCostAvia", typeof(float));
            floatUnitCostAvia.AllowDBNull = true;

            DataColumn strAvailability = new DataColumn("strAvailability", typeof(string));
            strAvailability.AllowDBNull = true;

            DataColumn strDescription = new DataColumn("strDescription", typeof(string));
            strDescription.AllowDBNull = true;

            DataColumn intSimsId = new DataColumn("intSimsId", typeof(int));
            intSimsId.AllowDBNull = true;

            DataColumn intPartStatus = new DataColumn("intPartStatus", typeof(int));
            intPartStatus.AllowDBNull = true;


            trackEvaluationPart.Columns.Add(intEvaluationPartId);
            trackEvaluationPart.Columns.Add(intEvalutionId);
            trackEvaluationPart.Columns.Add(floatQuantity);
            trackEvaluationPart.Columns.Add(floatUnitCostTrack);
            trackEvaluationPart.Columns.Add(floatUnitCostAvia);
            trackEvaluationPart.Columns.Add(strAvailability);
            trackEvaluationPart.Columns.Add(strDescription);
            trackEvaluationPart.Columns.Add(intSimsId);
            trackEvaluationPart.Columns.Add(intPartStatus);

            trackEvaluationPart.PrimaryKey = new DataColumn[] { trackEvaluationPart.Columns["intEvaluationPartId"] };

            #endregion

            #region  2table

            DataTable trackComponent = new DataTable("TrackComponent");
            Library.Tables.Add(trackComponent);

            DataColumn intComponentId = new DataColumn("intComponentId", typeof(int));
            intComponentId.AllowDBNull = false;
            intComponentId.Unique = true;
            intComponentId.AutoIncrement = true;
            intEvaluationPartId.AutoIncrementSeed = 1;
            intEvaluationPartId.AutoIncrementStep = 1;
            trackComponent.Columns.Add(intComponentId);
            trackComponent.PrimaryKey = new DataColumn[] { trackComponent.Columns["intComponentId"] };

            DataColumn strComponentId = new DataColumn("strComponentId", typeof(string));
            strComponentId.AllowDBNull = true;
            trackComponent.Columns.Add(strComponentId);

            DataColumn strUntil = new DataColumn("strUntil", typeof(string));
            strUntil.AllowDBNull = true;
            trackComponent.Columns.Add(strUntil);

            DataColumn intComponentTypeId = new DataColumn("intComponentTypeId", typeof(string));
            intComponentTypeId.AllowDBNull = true;
            trackComponent.Columns.Add(intComponentTypeId);

            DataColumn dInstalledOnMCS = new DataColumn("dInstalledOnMCS", typeof(DateTime))
            {
                AllowDBNull = false
            };
            trackComponent.Columns.Add(dInstalledOnMCS);

            DataColumn intEstimatedLife = new DataColumn("intEstimatedLife", typeof(int))
            {
                AllowDBNull = false
            };
            trackComponent.Columns.Add(intEstimatedLife);

            DataColumn dInitCycleDate = new DataColumn("dInitCycleDate", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(dInitCycleDate);

            DataColumn intInitCycleUnits = new DataColumn("intInitCycleUnits", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intInitCycleUnits);

            DataColumn intInitTotalUnits = new DataColumn("intInitTotalUnits", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intInitTotalUnits);

            DataColumn intEquipmentID = new DataColumn("intEquipmentID", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intEquipmentID);

            DataColumn LastDate = new DataColumn("LastDate", typeof(DateTime))
            {
                AllowDBNull = false
            };
            trackComponent.Columns.Add(LastDate);

            DataColumn intLastMetered = new DataColumn("intLastMetered", typeof(float))
            {
                AllowDBNull = false
            };
            trackComponent.Columns.Add(intLastMetered);

            DataColumn intTotalMetered = new DataColumn("intTotalMetered", typeof(float))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intTotalMetered);

            DataColumn intSMCSComponentID = new DataColumn("intSMCSComponentID", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intSMCSComponentID);

            DataColumn ModelID = new DataColumn("ModelID", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(ModelID);

            DataColumn intLocationId = new DataColumn("intLocationId", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intLocationId);

            DataColumn isRemoved = new DataColumn("isRemoved", typeof(bool))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(isRemoved);

            DataColumn intModifierId = new DataColumn("intModifierId", typeof(int))
            {
                AllowDBNull = true
            };
            trackComponent.Columns.Add(intModifierId);

            #endregion

            #region 3table

            DataTable pmChecklistPart = new DataTable("PMChecklistPart");
            Library.Tables.Add(pmChecklistPart);

            DataColumn intPMChecklistPartID = new DataColumn("intPMChecklistPartID", typeof(int))
            {
                AllowDBNull = false,          
                Unique = true,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };
            pmChecklistPart.Columns.Add(intPMChecklistPartID);
            pmChecklistPart.PrimaryKey = new DataColumn[] {pmChecklistPart.Columns["intPMChecklistPartID"] };

            DataColumn intPMChecklistStepID = new DataColumn("intPMChecklistStepID", typeof(int))
            {
                AllowDBNull = false
            };
            pmChecklistPart.Columns.Add(intPMChecklistStepID);

            DataColumn strPartNo = new DataColumn("strPartNo", typeof(string))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(strPartNo);

            DataColumn intQuantity = new DataColumn("intQuantity", typeof(int))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(intQuantity);

            DataColumn intIExtendedCost = new DataColumn("intIExtendedCost", typeof(int))
            {
                AllowDBNull = false
            };
            pmChecklistPart.Columns.Add(intIExtendedCost);

            DataColumn bitOptional = new DataColumn("bitOptional", typeof(bool))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(bitOptional);

            DataColumn intOriginalPartID = new DataColumn("intOriginalPartID", typeof(int))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(intOriginalPartID);

            DataColumn strPartDescription = new DataColumn("strPartDescription", typeof(string))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(strPartDescription);

            DataColumn intMasterPartID = new DataColumn("intMasterPartId", typeof(string) )
            {
                AllowDBNull = false
            };
            pmChecklistPart.Columns.Add(intMasterPartID);

            DataColumn intPMChecklistID = new DataColumn("intPMChecklistID", typeof(int))
            {
                AllowDBNull = true
            };
            pmChecklistPart.Columns.Add(intPMChecklistID);

            #endregion


            //foreach (DataRow item in trackEvaluationPart.Rows)
            //{
            //    foreach (var cell in item.ItemArray)
            //    {
            //        Console.Write("\t{0}", cell);
            //    }

            //}


            //Просмотр названия полей и его типов данных

            foreach (DataColumn item in trackEvaluationPart.Columns)
            {
                Console.WriteLine("\t" + item.ColumnName + " - " + item.DataType);
            }

            trackEvaluationPart.Rows.Add(new object[]{8, 1, 244, 1, 2.26, 2.03 });
            trackEvaluationPart.Rows.Add(new object[]{9, 1, 467, 2, 7448.28, 6691.27 });
            trackEvaluationPart.Rows.Add(new object[]{10, 1, 475, 3, 0, 724.14 });
            trackEvaluationPart.Rows.Add(new object[]{ 13, 1, 4806, 4, 0, 183.6 });

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("id \t EvaluationPart \t MasterPart \t Quantity \t UnitCost \t CostAvia");
            foreach (DataRow item in trackEvaluationPart.Rows)
            {
                foreach (var cell in item.ItemArray )
                {
                    Console.Write("{0}\t\t", cell);
                    
                }
                Console.WriteLine();
            }

          
        }

     

    }
}
