﻿using Core.Entities;
using System;

namespace Entities.DTOs
{
    public class NotDetayDto : IDto
    {
        public int Id { get; set; }
        public int SinavId { get; set; }
        public int OgrenciId { get; set; }
        public string SinavAdi { get; set; }
        public string DonemAdi { get; set; }
        public string DersAdi { get; set; }
        public DateTime SinavTarihi { get; set; }
        public string OgrenciAdi { get; set; }
        public string OgrenciSoyadi { get; set; }
        public int OgrenciNo { get; set; }
        public int SinavNot { get; set; }
    }

}
