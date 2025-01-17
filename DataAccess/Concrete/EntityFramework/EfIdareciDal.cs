﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfIdareciDal : EfEntityRepositoryBase<Idareci, OBSContext>, IIdareciDal
    {
        public List<IdareciDetayDto> GetIdareciDetaylari(Expression<Func<Idareci, bool>> filter = null)
        {
            using (OBSContext context = new OBSContext())
            {
                var result = from i in filter == null ? context.Idareciler : context.Set<Idareci>().Where(filter)
                             join u in context.Unvanlar on i.UnvanId equals u.Id
                             join f in context.Fakulteler on i.FakulteId equals f.Id
                             join ifo in context.IdareciFotograflar on i.Id equals ifo.IdareciId
                             select new IdareciDetayDto
                             {
                                Id=i.Id,
                                UnvanId=i.UnvanId,
                                FakulteId=i.FakulteId,
                                HashSifre=i.HashSifre,
                                SaltSifre=i.SaltSifre,
                                Isim = i.Isim,
                                Soyad = i.Soyad,
                                EMail = i.EMail,
                                Adres = i.Adres,
                                KayitTarihi = i.KayitTarihi,
                                TelefonNumarasi = i.TelefonNumarasi,
                                UnvanAdi = u.UnvanAdi,
                                FakulteAdi = f.FakulteAdi,
                                SicilNo = i.SicilNo,
                                fotografYolu = ifo.FotografYolu
                             };
                return result.ToList();
            }
        }
    }
}
