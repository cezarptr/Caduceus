﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DiseasesData
{
    public class Name
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; private set; }

        [Required]
        [MaxLength(50)]
        public string Value { get; private set; }

        [Required]
        public Guid DiseaseId { get; private set; }

        [ForeignKey("DiseaseId")]
        public virtual Disease Disease { get; private set; }

        public Name(Guid diseaseId, string value)
        {
            this.Id = Guid.NewGuid();
            this.Value = value;
            this.DiseaseId = diseaseId;
        }

        public Name(Disease disease, string value) 
            : this(disease.Id, value) { }
    }
}
