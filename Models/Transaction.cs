using System;
using System.ComponentModel.DataAnnotations;

namespace Bank_Accounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}
        [Required]
        [Range(1,Int32.MaxValue)]
        public int Amount {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public int UserId {get;set;}
        public User Creator {get;set;}
    }
}