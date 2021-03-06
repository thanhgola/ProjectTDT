﻿using Microsoft.Data.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTUniversal.DataContext
{
    public class TDTContext : DbContext
    {
        public DbSet<HocKy> HocKy { get; set; }
        public DbSet<MonHoc> MonHoc { get; set; }
        public DbSet<LichHoc> LichHoc { get; set; }
        public DbSet<ThongBao> ThongBao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=tdtuniversal.sqlite");
        }
    }
    public class HocKy
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HocKyId { get; set; }
        public string TenHocKy { get; set; }
        public DateTime NgayBatDau { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is HocKy)
                return HocKyId == (obj as HocKy).HocKyId;
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return HocKyId.GetHashCode();
        }
    }
    public class MonHoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int HocKyId { get; set; }

        [Required]
        public string TenMH { get; set; }
        public string MaMH { get; set; }
        public string Nhom { get; set; }
        public string To { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is MonHoc)
            {
                var other = obj as MonHoc;
                return HocKyId == other.HocKyId && TenMH == other.TenMH;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return TenMH.GetHashCode();
        }
    }
    public class LichHoc : IComparable<LichHoc>
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public int HocKyId { get; set; }
        [Required]
        public string TenMH { get; set; }

        public string Tiet { get; set; }
        public int Thu { get; set; }
        public string Phong { get; set; }
        public string Tuan { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is LichHoc)
            {
                var other = obj as LichHoc;
                return HocKyId == other.HocKyId && TenMH == other.TenMH;
            }
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return TenMH.GetHashCode();
        }

        public int CompareTo(LichHoc other)
        {
            int length = Math.Min(Tiet.Length, other.Tiet.Length);
            for (int i = 0; i < length; i++)
            {
                if (Tiet[i] != '-' || other.Tiet[i] != '-')
                {
                    if (Tiet[i] == '-')
                        return 1;
                    if (other.Tiet[i] == '-')
                        return -1;
                    for (int j = i; j < length; j++)
                    {
                        if (Tiet[i] == '-' || other.Tiet[i] == '-')
                        {
                            if (Tiet[i] != '-')
                                return 1;
                            if (other.Tiet[i] != '-')
                                return -1;
                        }
                    }
                    return 0;
                }
            }
            return 0;
        }
    }


}
