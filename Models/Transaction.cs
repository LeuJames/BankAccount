using System;
using System.ComponentModel.DataAnnotations;

    namespace BankAccount.Models
    {
        public class Transaction
        {
            [Key]
            public int TransactionId { get; set; }

            [Required]
            [Display(Name = "Amount:")]
            [DataType(DataType.Currency)]
            [DisplayFormat(NullDisplayText = "-", 
              ApplyFormatInEditMode = true, 
              DataFormatString = "{0:C}")]
            public decimal Amount { get; set; }
            public DateTime CreatedAt {get;set;} = DateTime.Now;
            
            public int UserId {get;set;}

            public User Owner {get; set;}
        }
    }