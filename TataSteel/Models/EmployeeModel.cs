using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace TataSteel.Models
{
    public class EmployeeModel
    {
        [BsonId]
        public ObjectId ID { get; set; }
        [BsonElement("Type_of_Property")]
        public string Type_of_Property { get; set; }
        [BsonElement("Location")]
        public string Location { get; set; }
        [BsonElement("Rent")]
        public double Rent { get; set; }
        [BsonElement("StartDate")]
        public string StartDate { get; set; }
        [BsonElement("EndDate")]
        public string EndDate { get; set; }
        [BsonElement("Contact_Number")]
        public int ContactNumber { get; set; }
        [BsonElement("Details")]
        public string Details { get; set; }
    }
}