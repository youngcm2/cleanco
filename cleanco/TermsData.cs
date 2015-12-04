using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cleanco
{
    internal static class TermsData
    {
        public static Dictionary<string, HashSet<string>> TermsByType = new Dictionary<string, HashSet<string>>
        {
            {
                "Corporation", new HashSet<string>
                {
                    "company",
                    "incorporated",
                    "corporation",
                    "corp.",
                    "corp",
                    "inc",
                    "& co.",
                    "& co",
                    "inc.",
                    "s.p.a.",
                    "n.v.",
                    "a.g.",
                    "ag",
                    "nuf",
                    "s.a.",
                    "s.f.",
                    "oao",
                    "co.",
                    "co"
                }
            },
            {
                "General Partnership", new HashSet<string>
                {
                    "soc.col.",
                    "stg",
                    "d.n.o.",
                    "ltda.",
                    "v.o.s.",
                    "kgaa",
                    "o.e.",
                    "s.f.",
                    "s.n.c.",
                    "s.a.p.a.",
                    "j.t.d.",
                    "v.o.f.",
                    "sp.j.",
                    "og",
                    "sd",
                    "vos",
                    " i/s",
                    "ay",
                    "snc",
                    "oe",
                    "bt.",
                    "s.s.",
                    "mb",
                    "ans",
                    "da",
                    "o.d.",
                    "hb",
                    "pt"
                }
            },
            {
                "Joint Stock / Unlimited", new HashSet<string>
                {
                    "unltd",
                    "ultd",
                    "sal",
                    "unlimited",
                    "saog",
                    "saoc",
                    "aj",
                    "yoaj",
                    "oaj"
                }
            },
            {
                "Joint Venture", new HashSet<string>
                {
                    "esv",
                    "gie",
                    "kv.",
                    "qk"
                }
            },
            {
                "Limited", new HashSet<string>
                {
                    "pty. ltd.",
                    "pty ltd",
                    "ltd",
                    "l.t.d.",
                    "bvba",
                    "d.o.o.",
                    "ltda",
                    "gmbh",
                    "g.m.b.h",
                    "kft.",
                    "kht.",
                    "zrt.",
                    "ehf.",
                    "s.a.r.l.",
                    "d.o.o.e.l.",
                    "s. de r.l.",
                    "b.v.",
                    "tapui",
                    "sp. z.o.o.",
                    "s.r.l.",
                    "s.l.",
                    "s.l.n.e.",
                    "ood",
                    "oy",
                    "rt.",
                    "teo",
                    "uab",
                    "scs",
                    "sprl",
                    "limited",
                    "bhd.",
                    "sdn. bhd.",
                    "sdn bhd",
                    "as",
                    "lda.",
                    "tov",
                    "pp"
                }
            },
            {
                "Limited Liability Company", new HashSet<string>
                {
                    "pllc",
                    "llc",
                    "l.l.c.",
                    "plc.",
                    "plc",
                    "hf.",
                    "oyj",
                    "a.e.",
                    "nyrt.",
                    "p.l.c.",
                    "sh.a.",
                    "s.a.",
                    "s.r.l.",
                    "srl.",
                    "aat",
                    "3at",
                    "d.d.",
                    "akc. spol.",
                    "a.s.",
                    "s.r.o.",
                    "s.m.b.a.",
                    "smba",
                    "sarl",
                    "nv",
                    "sa",
                    "aps",
                    "a/s",
                    "p/s",
                    "sae",
                    "sasu",
                    "eurl",
                    "ae",
                    "cpt",
                    "as",
                    "ab",
                    "asa",
                    "ooo",
                    "dat",
                    "vat",
                    "zat",
                    "mchj",
                    "a.d."
                }
            },
            {
                "Limited Liability Limited Partnership", new HashSet<string>
                {
                    "lllp",
                    "l.l.l.p."
                }
            },
            {
                "Limited Liability Partnership", new HashSet<string>
                {
                    "llp",
                    "l.l.p.",
                    "sp.p.",
                    "s.c.a.",
                    "s.c.s."
                }
            },
            {
                "Limited Partnership", new HashSet<string>
                {
                    "gmbh & co. kg",
                    "gmbh & co. kg",
                    "lp",
                    "l.p.",
                    "s.c.s.",
                    "s.c.p.a",
                    "comm.v",
                    "k.d.",
                    "k.d.a.",
                    "s. en c.",
                    "e.e.",
                    "s.a.s.",
                    "s. en c.",
                    "c.v.",
                    "s.k.a.",
                    "sp.k.",
                    "s.cra.",
                    "ky",
                    "scs",
                    "kg",
                    "kd",
                    "k/s",
                    "ee",
                    "secs",
                    "kda",
                    "ks",
                    "kb",
                    "kt"
                }
            },
            {
                "Mutual Fund", new HashSet<string>
                {
                    "sicav"
                }
            },
            {
                "No Liability", new HashSet<string>
                {
                    "nl"
                }
            },
            {
                "Non-Profit", new HashSet<string>
                {
                    "vzw",
                    "ses.",
                    "gte."
                }
            },
            {
                "Private Company", new HashSet<string>
                {
                    "private",
                    "pte",
                    "xk"
                }
            },
            {
                "Professional Corporation", new HashSet<string>
                {
                    "p.c.",
                    "vof",
                    "snc"
                }
            },
            {
                "Professional Limited Liability Company", new HashSet<string>
                {
                    "pllc",
                    "p.l.l.c."
                }
            },
            {
                "Sole Proprietorship", new HashSet<string>
                {
                    "e.u.",
                    "s.p.",
                    "t:mi",
                    "tmi",
                    "e.v.",
                    "e.c.",
                    "et",
                    "obrt",
                    "fie",
                    "ij",
                    "fop",
                    "xt"
                }
            }
        };

        public static Dictionary<string, HashSet<string>> TermsByCountry = new Dictionary<string, HashSet<string>>
        {
            {"Albania", new HashSet<string> {"sh.a.", "sh.p.k."}},
            {
                "Argentina", new HashSet<string>
                {
                    "s.a.",
                    "s.r.l.",
                    "s.c.p.a",
                    "scpa",
                    "s.c.e i.",
                    "s.e.",
                    "s.g.r",
                    "soc.col."
                }
            },
            {"Australia", new HashSet<string> {"nl", "pty. ltd.", "pty ltd"}},
            {"Austria", new HashSet<string> {"e.u.", "stg", "gesbr", "a.g.", "ag", "og", "kg"}},
            {"Belarus", new HashSet<string> {"aat", "3at"}},
            {
                "Belgium", new HashSet<string>
                {
                    "esv",
                    "vzw",
                    "vof",
                    "snc",
                    "comm.v",
                    "scs",
                    "bvba",
                    "sprl",
                    "cbva",
                    "cvoa",
                    "sca",
                    "sep",
                    "gie"
                }
            },
            {"Bosnia / Herzegovina", new HashSet<string> {"d.d.", "a.d.", "d.n.o.", "d.o.o.", "k.v.", "s.p."}},
            {"Brazil", new HashSet<string> {"ltda", "s.a.", "pllc", "ad", "adsitz", "ead", "et", "kd", "kda", "sd"}},
            {"Bulgaria", new HashSet<string> {"ad", "adsitz", "ead", "et", "kd", "kda", "sd"}},
            {"Cambodia", new HashSet<string> {"gp", "sm pte ltd.", "pte ltd.", "plc ltd.", "peec", "sp"}},
            {"Canada", new HashSet<string> {"gp", "lp", "sp"}},
            {
                "Chile", new HashSet<string>
                {
                    "eirl",
                    "s.a.",
                    "sgr",
                    "s.g.r.",
                    "ltda",
                    "s.p.a.",
                    "sa",
                    "s. en c.",
                    "ltda."
                }
            },
            {"Columbia", new HashSet<string> {"s.a.", "e.u.", "s.a.s.", "suc. de descendants", "sca"}},
            {"Croatia", new HashSet<string> {"d.d.", "d.d.o.", "obrt"}},
            {"Czech Republic", new HashSet<string> {"a.s.", "akc. spol.", "s.r.o.", "v.o.s.", "k.s.", "sro", "vos"}},
            {
                "Denmark", new HashSet<string>
                {
                    "i/s",
                    "a/s",
                    "k/s",
                    "p/s",
                    "amba",
                    "a.m.b.a.",
                    "fmba",
                    "f.m.b.a.",
                    "smba",
                    "s.m.b.a.",
                    "g/s"
                }
            },
            {
                "Dominican Republic", new HashSet<string>
                {
                    "c. por a.",
                    "cxa",
                    "s.a.",
                    "s.a.s.",
                    "srl.",
                    "eirl.",
                    "sa",
                    "sas"
                }
            },
            {"Ecuador", new HashSet<string> {"s.a.", "c.a.", "sa", "ep"}},
            {"Egypt", new HashSet<string> {"sae"}},
            {"Estonia", new HashSet<string> {"fie"}},
            {"Finland", new HashSet<string> {"t:mi", "tmi", "as oy", "as.oy", "ay", "ky", "oy", "oyj", "ok"}},
            {
                "France", new HashSet<string>
                {
                    "sicav",
                    "sarl",
                    "sogepa",
                    "ei",
                    "eurl",
                    "sasu",
                    "fcp",
                    "gie",
                    "sep",
                    "snc",
                    "scs",
                    "sca",
                    "scop",
                    "sem",
                    "sas"
                }
            },
            {
                "Germany", new HashSet<string>
                {
                    "gmbh & co. kg",
                    "gmbh & co. kg",
                    "e.g.",
                    "e.v.",
                    "gbr",
                    "ohg",
                    "partg",
                    "kgaa",
                    "gmbh",
                    "g.m.b.h.",
                    "ag"
                }
            },
            {
                "Greece", new HashSet<string>
                {
                    "a.e.",
                    "ae",
                    "e.e.",
                    "ee",
                    "epe",
                    "e.p.e.",
                    "mepe",
                    "m.e.p.e.",
                    "o.e.",
                    "oe",
                    "ovee",
                    "o.v.e.e."
                }
            },
            {"Guatemala", new HashSet<string> {"s.a.", "sa"}},
            {"Haiti", new HashSet<string> {"sa"}},
            {"Hong Kong", new HashSet<string> {"ltd", "unltd", "ultd", "limited"}},
            {
                "Hungary", new HashSet<string>
                {
                    "e.v.",
                    "e.c.",
                    "bt.",
                    "kft.",
                    "kht.",
                    "kkt.",
                    "k.v.",
                    "zrt.",
                    "nyrt",
                    "ev",
                    "ec",
                    "rt."
                }
            },
            {"Iceland", new HashSet<string> {"ehf.", "hf.", "ohf.", "s.f.", "ses."}},
            {"India", new HashSet<string> {"pvt. ltd.", "ltd.", "psu", "pse"}},
            {"Indonesia", new HashSet<string> {"ud", "fa", "pt"}},
            {"Ireland", new HashSet<string> {"cpt", "teo"}},
            {"Israel", new HashSet<string> {"b.m.", "bm", "ltd", "limited"}},
            {"Italy", new HashSet<string> {"s.n.c.", "s.a.s.", "s.p.a.", "s.a.p.a.", "s.r.l.", "s.c.r.l.", "s.s."}},
            {"Latvia", new HashSet<string> {"as", "sia", "ik", "ps", "ks"}},
            {"Lebanon", new HashSet<string> {"sal"}},
            {"Lithuania", new HashSet<string> {"uab", "ab", "ij", "mb"}},
            {"Luxemborg", new HashSet<string> {"s.a.", "s.a.r.l.", "secs"}},
            {"Macedonia", new HashSet<string> {"d.o.o.", "d.o.o.e.l", "k.d.a.", "j.t.d.", "a.d.", "k.d."}},
            {"Malaysia", new HashSet<string> {"bhd.", "sdn. bhd."}},
            {"Mexico", new HashSet<string> {"s.a.", "s. de. r.l.", "s. en c.", "s.a.b.", "s.a.p.i."}},
            {"Mongolia", new HashSet<string> {"xk", "xxk"}},
            {"Netherlands", new HashSet<string> {"v.o.f.", "c.v.", "b.v.", "n.v."}},
            {"New Zealand", new HashSet<string> {"tapui", "ltd", "limited"}},
            {"Nigeria", new HashSet<string> {"gte.", "plc", "ltd.", "ultd."}},
            {
                "Norway", new HashSet<string>
                {
                    "asa",
                    "as",
                    "ans",
                    "ba",
                    "bl",
                    "da",
                    "etat",
                    "fkf",
                    "hf",
                    "iks",
                    "kf",
                    "ks",
                    "nuf",
                    "rhf",
                    "sf"
                }
            },
            {"Oman", new HashSet<string> {"saog", "saoc"}},
            {"Pakistan", new HashSet<string> {"ltd.", "pvt. ltd.", "ltd", "limited"}},
            {"Peru", new HashSet<string> {"sa", "s.a.", "s.a.a."}},
            {
                "Philippines",
                new HashSet<string> {"coop.", "corp.", "corp", "ent.", "inc.", "inc", "llc", "l.l.c.", "ltd."}
            },
            {"Poland", new HashSet<string> {"p.p.", "s.k.a.", "sp.j.", "sp.k.", "sp.p.", "sp. z.o.o.", "s.c.", "s.a."}},
            {"Portugal", new HashSet<string> {"lda.", "crl", "s.a.", "s.f.", "sgps"}},
            {"Romania", new HashSet<string> {"s.c.a.", "s.c.s.", "s.n.c.", "s.r.l.", "o.n.g.", "s.a."}},
            {"Russia", new HashSet<string> {"ooo", "oao", "zao", "3ao"}},
            {"Serbia", new HashSet<string> {"d.o.o.", "a.d.", "k.d.", "o.d."}},
            {"Singapore", new HashSet<string> {"bhd", "pte ltd", "sdn bhd", "llp", "l.l.p.", "ltd.", "pte"}},
            {"Slovenia", new HashSet<string> {"d.d.", "d.o.o.", "d.n.o.", "k.d.", "s.p."}},
            {"Slovokia", new HashSet<string> {"a.s.", "s.r.o.", "k.s.", "v.o.s."}},
            {
                "Spain", new HashSet<string>
                {
                    "s.a.",
                    "s.a.d.",
                    "s.l.",
                    "s.l.l.",
                    "s.l.n.e.",
                    "s.c.",
                    "s.cra",
                    "s.coop",
                    "sal",
                    "sccl"
                }
            },
            {"Sweden", new HashSet<string> {"ab", "hb", "kb"}},
            {"Switzerland", new HashSet<string> {"ab", "sa", "gmbh", "g.m.b.h.", "sarl", "sagl"}},
            {"Turkey", new HashSet<string> {"koop."}},
            {"Ukraine", new HashSet<string> {"dat", "fop", "kt", "pt", "tdv", "tov", "pp", "vat", "zat", "at"}},
            {
                "United Kingdom",
                new HashSet<string>
                {
                    "plc.",
                    "plc",
                    "cic",
                    "cio",
                    "l.l.p.",
                    "llp",
                    "l.p.",
                    "lp",
                    "ltd.",
                    "ltd",
                    "limited"
                }
            },
            {
                "United States of America", new HashSet<string>
                {
                    "llc",
                    "inc.",
                    "corporation",
                    "incorporated",
                    "company",
                    "limited",
                    "corp.",
                    "inc.",
                    "inc",
                    "llp",
                    "l.l.p.",
                    "pllc",
                    "and company",
                    "& company",
                    "inc",
                    "inc.",
                    "corp.",
                    "corp",
                    "ltd.",
                    "ltd",
                    "& co.",
                    "& co",
                    "co.",
                    "co",
                    "lp"
                }
            },
            {"Uzbekistan", new HashSet<string> {"mchj", "qmj", "aj", "oaj", "yoaj", "xk", "xt", "ok", "uk", "qk"}}
        };
    }
}
