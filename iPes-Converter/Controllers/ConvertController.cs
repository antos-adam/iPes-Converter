using DochazkaAPI.Enums;
using DochazkaAPI.Models;
using iPes_Converter.ModelsOld;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iPes_Converter.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConvertController : ControllerBase
    {
        private readonly AppDbContext _newContext;
        private readonly edora2Context _oldContext;

        public ConvertController(AppDbContext newContext, edora2Context oldContext)
        {
            _newContext = newContext;
            _oldContext = oldContext;
        }

        [HttpGet("Auta")]
        public List<Auto> AutaConvert()
        {
            List<Autum> Auta = _oldContext.Auta.ToList();
            foreach(Autum aut in Auta)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Auto newAuto = new Auto();
                    newAuto.IdAuta = aut.IdAuta;
                    newAuto.Barva = aut.Barva;
                    newAuto.Benzin = aut.Benzin;
                    newAuto.Maxpocmist = aut.Maxpocmist;
                    newAuto.Platnostccs = aut.Platnostccs;
                    newAuto.Spotreba = (double?)aut.Spotreba;
                    newAuto.Spz = aut.Spz;
                    newAuto.Techkontr = aut.Techkontr;
                    newAuto.Techstav = aut.Techstav;
                    newAuto.Typauta = aut.Typauta;
                    newAuto.Vyrazeno = aut.Vyrazeno;


                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Auta] ON");

                    _newContext.Add(newAuto);
                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Auta] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Auta.ToList();
        }

        [HttpGet("Odbory")]
        public List<Odbor> OdboryConvert()
        {
            List<Odbory> Odbory = _oldContext.Odbories.ToList();
            foreach (Odbory odb in Odbory)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    Odbor newOdbor = new();
                    newOdbor.IdOdbor = odb.IdOdbor;
                    newOdbor.ZkrOd = odb.ZkrOd;
                    newOdbor.NazevOd = odb.NazevOd;

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Odbory] ON");

                    _newContext.Add(newOdbor);
                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Odbory] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Odbory.ToList();
        }

        [HttpGet("Parametry")]
        public List<DochazkaAPI.Models.Parametry> ParametryConvert()
        {
            List<ModelsOld.Parametry> Parametry = _oldContext.Parametries.ToList();
            foreach (ModelsOld.Parametry par in Parametry)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Parametry newPar = new()
                    {
                        IdParam = par.IdParam,
                        IdPd = par.IdPd,
                        MinZacPdGt = par.MinZacPdGt, 
                        DelObed = par.DelObed, 
                        IdObed = par.IdObed, 
                        KorekceKonec = par.KorekceKonec,
                        KorekceZacatek = par.KorekceZacatek, 
                        Nazevorg = par.Nazevorg, 
                        RefreshInt = par.RefreshInt, 
                        TsUstredna = par.TsUstredna
                    };

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Parametry] ON");

                    _newContext.Add(newPar);
                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Parametry] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Parametry.ToList();
        }

        [HttpGet("Svatky")]
        public List<DochazkaAPI.Models.Svatek> SvatkyConvert()
        {
            List<ModelsOld.Svatky> Svatky = _oldContext.Svatkies.ToList();
            foreach (ModelsOld.Svatky svat in Svatky)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Svatek newSvat = new()
                    { DatSvat = svat.DatSvat, IdSvatku = svat.IdSvatku, NazSvat = svat.NazSvat };

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Svatky] ON");

                    _newContext.Add(newSvat);
                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Svatky] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Svatky.ToList();
        }

        [HttpGet("Udalosti")]
        public List<DochazkaAPI.Models.Udalost> UdalostiConvert()
        {
            List<ModelsOld.Udalost> Udalosti = _oldContext.Udalosts.ToList();
            foreach (ModelsOld.Udalost udal in Udalosti)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Udalost newUdal = new()
                    { CasIn = udal.CasIn, DatumIn = udal.DatumIn, DnyIn = udal.DnyIn, IdUdalosti = udal.IdUdalosti, MaxCas = udal.MaxCas, MaxDny = (double)udal.MaxDny, MaxOpak = udal.MaxOpak, MinCas = udal.MinCas, MinDny = (double)udal.MinDny, Nazev = udal.Nazev, Prepovol = udal.Prepovol, Preruseni = udal.Preruseni, System = udal.System, TypuTisk = udal.TypuTisk, VypObedy = udal.VypObedy, VypPracdoby = udal.VypPracdoby, Zakladni = udal.Zakladni, Vysvetlivky = udal.Vysvetlivky, ZkrUdal = udal.ZkrUdal };

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Udalosti] ON");

                    _newContext.Add(newUdal);
                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Udalosti] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Udalosti.ToList();
        }

        [HttpGet("Zamestnanci")]
        public List<DochazkaAPI.Models.Zamestnanec> ZamestnanciConvert()
        {
            List<ModelsOld.Zamest> Zamestnanci = _oldContext.Zamests.ToList();
            foreach (ModelsOld.Zamest zamest in Zamestnanci)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Zamestnanec newZamest = new()
                    { IdZam = zamest.IdZam, Denuvazek = (double)zamest.Denuvazek, IdOdbor = zamest.IdOdbor, Jmeno = zamest.Jmeno, ZobrazVKontPritom = zamest.Pr3, NevkladatPauzuObed = zamest.Pr4, NezkracovatPriViceHod = zamest.Pr5, NezobrazVNepritomnosti = zamest.Pr0, Prijmeni = zamest.Prijmeni, Titul = zamest.Titul, TsDaktmob = zamest.TsDaktmob, TsDaktpev = zamest.TsDaktpev, TsEmail = zamest.TsEmail, TsMobil = zamest.TsMobil, TsPevna = zamest.TsPevna, Vyrazen = zamest.Vyrazen };

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Zamestnanci] ON");
                    _newContext.Add(newZamest);

                    if (zamest.Vyrazen == false && zamest.PrPritomnost == true) _newContext.Add(new RoleZamestnanec() { IdZam = zamest.IdZam, Agenda = AgendaEnum.VsechnyAgendy, Role = RoleEnum.Zamestnanec, VychoziRole = true });
                    if (zamest.Vedouci == true) _newContext.Add(new RoleZamestnanec() { IdZam = zamest.IdZam, Agenda = AgendaEnum.VsechnyAgendy, Role = RoleEnum.Vedouci });
                    if (zamest.AdminAll == true) _newContext.Add(new RoleZamestnanec() { IdZam = zamest.IdZam, Agenda = AgendaEnum.VsechnyAgendy, Role = RoleEnum.Administrator });
                    if (zamest.AdminDo == true) _newContext.Add(new RoleZamestnanec() { IdZam = zamest.IdZam, Agenda = AgendaEnum.Dochazka, Role = RoleEnum.Administrator });
                    if (zamest.AdminRa == true) _newContext.Add(new RoleZamestnanec() { IdZam = zamest.IdZam, Agenda = AgendaEnum.RezervaceAut, Role = RoleEnum.Administrator });

                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Zamestnanci] OFF");

                    transaction.Commit();
                }


            }

            return _newContext.Zamestnanci.ToList();
        }

        [HttpGet("RezervaceAut")]
        public string RezervaceAutConvert()
        {
            List<ModelsOld.Rezaut> Rezervace = _oldContext.Rezauts.ToList();
            foreach (ModelsOld.Rezaut rez in Rezervace)
            {
                using (var transaction = _newContext.Database.BeginTransaction())
                {
                    DochazkaAPI.Models.Rezauta newRez = new()
                    { Cesta = rez.Cesta, Dulezitost = rez.Dulezitost, Duvod = rez.Duvod, IdAuta = rez.IdAuta, IdOdbor = rez.IdOdbor, IdRezerv = rez.IdRezerv, IdRidic = rez.IdRidic, IdSpolc1 = rez.IdSpolc1, IdSpolc2 = rez.IdSpolc2, IdSpolc3 = rez.IdSpolc3, IdSpolc4 = rez.IdSpolc4, IdSpolc5 = rez.IdSpolc5, IdZam = rez.IdZam, OdpRead = rez.OdpRead, Pozadavky = rez.Pozadavky, Poznamky = rez.Poznamky, RezervDo = rez.RezervDo, RezervOd = rez.RezervOd, Stavrez = rez.Stavrez, ZamDele = rez.ZamDele, Zmenaterm = rez.Zmenaterm };

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Rezaut] ON");
                    _newContext.Add(newRez);

                    _newContext.SaveChanges();

                    _newContext.Database.ExecuteSqlRaw("SET IDENTITY_INSERT [dbo].[Rezaut] OFF");

                    transaction.Commit();
                }


            }

            return "Done";
        }
    }
}
