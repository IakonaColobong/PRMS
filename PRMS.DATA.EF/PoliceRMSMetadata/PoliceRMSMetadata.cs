using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PRMS.DATA.EF//PoliceRMSMetadata
{

    [MetadataType(typeof(AmmunitionMetadata))]
    public partial class Ammunition { }
    public class AmmunitionMetadata
    {

        //public int Id { get; set; }
        [Required]
        [Display(Name = "Caliber")]
        [StringLength(10, ErrorMessage = "Entry too long")]
        public string Caliber { get; set; }

        [DisplayFormat(NullDisplayText = "Supplier not provided")]
        [StringLength(50, ErrorMessage = "Entry too long")]
        public string Supplier { get; set; }

        [DisplayFormat(NullDisplayText = "Quantity not provided")]
        public Nullable<int> Qty { get; set; }


    }

    [MetadataType(typeof(EmployeeMetadata))]
    public partial class Employee
    { }
    public class EmployeeMetadata
    {
        //public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string First_Name { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Last_Name { get; set; }

        [DisplayFormat(NullDisplayText = "Badge not provided")]
        public string Badge { get; set; }

        [Display(Name = "Hire Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> Date_Of_Hire { get; set; }

        [Display(Name = "Termination Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> Date_of_Termination { get; set; }

        [Display(Name = "Hourly Pay Rate")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public string Pay_Rate_Hourly { get; set; }

        [Required]
        [Display(Name = "Positional Title")]
        public string Title { get; set; }


        [Display(Name = "Effective Promotion Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public string Promotion_Date { get; set; }
    }


    [MetadataType(typeof(FirearmMetadata))]
    public partial class Firearm
    { }
    public class FirearmMetadata
    {
        //public int Id { get; set; }
        [DisplayFormat(NullDisplayText = "*")]
        [StringLength(20, ErrorMessage = "Entry too long, 20 char max")]
        public string SerialNumber { get; set; }

        [DisplayFormat(NullDisplayText = "*")]
        [StringLength(15, ErrorMessage = "Entry too long, 15 char max")]
        public string Make { get; set; }

        [DisplayFormat(NullDisplayText = "*")]
        [StringLength(20, ErrorMessage = "Entry too long, 20 char max")]
        public string Model { get; set; }

        //[Required]
        //this will be the location of WHO has the item
        //public int Location { get; set; }


        //public string EmployeeID { get; set; }

        //[Display(Name = "Vehicle Assigned To")]
        //[StringLength(10, ErrorMessage = "Entry too long, 10 char max")]
        //public string VehicleNumber { get; set; }

        [Display(Name = "Purchase Price")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Nullable<decimal> PurchasePrice { get; set; }
    }


    public class TrainingMetadata
    {
        //public int id { get; set; }
        //public int EmployeeId { get; set; }
        [Required]
        [Display(Name = "Class Name")]
        [StringLength(50, ErrorMessage = "Entry too long, 50 char max")]
        public string ClassName { get; set; }

        [Required]
        [Display(Name = "Date Attended")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public System.DateTime DateAttended { get; set; }

        [Display(Name = "Training Hours")]
        public Nullable<int> TrainingHours { get; set; }

        [Display(Name = "Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Cost { get; set; }
    }

    public class VehicleMetadata
    {
        //public int VehicleID { get; set; }

        [Display(Name = "Vehicle Number")]
        public Nullable<int> VehicleNumber { get; set; }



        [Required]
        [Display(Name = "VIN")]
        public int VIN { get; set; }

        [Required]
        [Display(Name = "Make")]
        [StringLength(20, ErrorMessage = "Entry too long, 20 char max")]
        public string Make { get; set; }

        [Required]
        [Display(Name = "Model")]
        [StringLength(20, ErrorMessage = "Entry too long, 20 char max")]
        public string Model { get; set; }


        [Display(Name = "Model Year")]
        [StringLength(20, ErrorMessage = "Entry too long, 20 char max")]
        public string ModelYear { get; set; }


        [Display(Name = "Purchase Date")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public Nullable<System.DateTime> PurchaseDate { get; set; }


        [Display(Name = "Cost")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Nullable<decimal> PurchasePrice { get; set; }


        [Display(Name = "Date Retired")]
        public Nullable<System.DateTime> DateOutOfService { get; set; }
        //public Nullable<int> EmployeeId { get; set; }

        [Required]
        [Display(Name = "In Maint?")]
        public bool IsInMaint { get; set; }
    }
    [MetadataType(typeof(VehicleMetadata))]
    public partial class Vehicle
    { }

}
