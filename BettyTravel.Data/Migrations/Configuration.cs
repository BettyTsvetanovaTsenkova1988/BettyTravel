using System.Collections.Generic;
using BettyTravelApp.Models.EntityModels;
using BettyTravelApp.Models.Enumerations;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BettyTravel.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BettyTravel.Data.BettyTravelContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(BettyTravel.Data.BettyTravelContext context)
        {
            if (!context.Roles.Any(role => role.Name == "customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("customer");
                manager.Create(role);
            }
           
            if (!context.Roles.Any(role => role.Name == "admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("admin");
                manager.Create(role);
            }

            //ontext.Vacations.AddOrUpdate(v => v.Id,
            //   new Vacation()
            //   {
            //       VacationName = "Албена",
            //       VacationDescription = "SOL NESSEBAR RESORT e заобиколен от зеленина, разположен до самия бряг с възможности за незабравима почивка. Курортът SOL NESSEBAR се състои от хотелите SOL NESSEBAR BAY, SOL NESSEBAR MARE и SOL NESSEBAR PALACE /5 */. Хотелът се намира на 2,5км. от центъра на Несебър и на 20 мин от летище Бургас.\r\n\r\nВ стаите:\r\nВсяка стая разполага с климатик, телевизор, телефон, мини бар, баня с душ/вана, сешоар, тоалетни принадлежности, сейф/платен/, WI-FI/безплатно/.\r\n\r\nНа територията на хотела:\r\nосновен ресторант, а-ла-карт ресторант /италиански, немски, испански и японски/(от Юни до Септември), 3 бара, дискотека, Аквапарк/отворен от 01.06/, външен и вътрешен басейн, СПА център, фитнес, тенис на маса, тенис на корт, мини голф, анимация, магазини, доктор на повикване.\r\n\r\nБезплатни услуги: фитнес, тенис на маса, дартс, мини клуб /4-12г./, WI-FI",
            //       Category = new Category() { CategoryName = CategoryType.BlackSea },
            //       FeedingType = FeedingType.Fullbase,
            //       StartPeriod = DateTime.Today,
            //       EndPeriod = new DateTime(2017, 10, 10),
            //       Picures = new List<Picure>()
            //       {
            //          new Picure() {PictureSourse = "~\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\2247940.jpg"},
            //           new Picure() {PictureSourse = "~\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\2352012.jpg"},
            //            new Picure() {PictureSourse = "~\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\19255948.jpg"},
            //       },
            //       Price = 1000,
            //       TransportType = TransportType.Bus
            //   });
            context.Vacations.AddOrUpdate(v => v.Id,
               new Vacation()
               {
                   VacationName = "Австрия",
                   VacationDescription = "4-звездният Heritage Hotel Hallstatt предлага комфорт и удобство независимо дали пътувате поради бизнес или ваканция в Халстат. Хотелът разполага с всичко необходимо, за да Ви осигури комфортен престой. В хотела са налични безплатен WiFi достъп във всички стаи, съоръжения за инвалиди, експресно настаняване/напускане, съхраняване на багаж, Wi-Fi връзка в общите части. Комфортните стаи гарантират добър нощен сън с помощта на удобства в някои от тях като събуждане, отопление, балкон/тераса, минибар, бюро. За да подобри престоя на гостите, хотелът предлага развлекателни съоръжения като например сауна, каране на ски, гмуркане, риболов, детска площадка. Без значение какви са причините за Вашето посещение в Халстат, Heritage Hotel Hallstatt ще Ви накара да се почувствате като у дома.",
                   Category = new Category() { CategoryName = CategoryType.SkiingAbroad },
                   FeedingType = FeedingType.Fullbase,
                   StartPeriod = new DateTime(2017, 10, 10),
                   EndPeriod = new DateTime(2017, 10, 20),
                   Picures = new List<Picure>()
                   {
                       new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\avstria\\77111571.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\avstria\\77114839.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\avstria\\81480563.jpg"},
                   },
                   Price = 1200,
                   TransportType = TransportType.Airplane
               });

            context.Vacations.AddOrUpdate(v => v.Id,
               new Vacation()
               {
                   VacationName = "Швейцария",
                   VacationDescription = "Allegro е четиризвезден хотел разположен на тихо място в центъра на град Берн, с изглед към Алпите и средновековния град. Хотел Allegro е само на 2 км от магистралата и на пет минути с автомобил от централната железопътна гара, пред сградата има спирка за градски транспорт. Хотелът разполага със 171 стаи и апартаменти, всички оборудвани с минибар, климатик, кафе машина, сейф, телевизор, телефон. Стаите са с прозорци, които се отварят. Баните са с вана или душ, има и сешоар. На разположение на гостите е най-големият конгресен център в региона, а за любителите на хазартните игри има казино. В трите ресторанта се приготвя интернационална и местна кухня, има и два бара. Гостите могат да се насладят на уелнес центъра, който разполага с джакузи, сауна и турска парна баня и да поспортуват във фитнес центъра. Други удобства са денонощна рецепция, румсървиз, стая за съхранение на багаж, гладене, пране, химическо чистене. Хотелът предлага валутна обмяна на рецепцията и магазин за сувенири и подаръци. Сградата е с асансьор и е пригодена за хора с увреждания. Допускат се домашни любимци. Гостите могат да ползват интернет и паркинг срещу заплащане.",
                   Category = new Category() { CategoryName = CategoryType.SkiingAbroad },
                   FeedingType = FeedingType.Breakfast,
                   StartPeriod = new DateTime(2017, 10, 20),
                   EndPeriod = new DateTime(2017, 10, 30),
                   Picures = new List<Picure>()
                   {
                       new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\shveitsaria\\s1.jpeg"},
                        new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\shveitsaria\\s2.jpeg"},
                         new Picure() {PictureSourse = "\\Content\\images\\skiing\\abroad\\shveitsaria\\s3.jpeg"},
                   },
                   Price = 1340,
                   TransportType = TransportType.Airplane
               });

            context.Vacations.AddOrUpdate(v => v.Id,
               new Vacation()
               {
                   VacationName = "Боровец",
                   VacationDescription = "Хотел Самоков е категоризиран с четири звезди и се намира в централната част на зимния курортен комплекс Боровец. Хотелът разполага с 261 стаи и 4 апартамента. Всички помещения са с тераса и са оборудвани с телевизор със сателитни програми, мини бар, сешоар и телефон със възможност за директно избиране, както на национални, така и международни линии. Стаите разполагат с баня с вана. В ресторант Самоков закуската се предлага на блок маса. За обяд и вечеря гостите могат да избират ястия от меню. Ресторант Панорама е с панорамна гледка към планината. Лоби бар, спортен бар и такъв около басейна са на разположение на посетителите, както и нощен клуб с 220 места. Деловите гости могат да се възползват от осем конферентни зали, с различен капацитет и големина. Всички те са оборудвани и приспособени за провеждане на конференции, семинари и фирмени обучения. СПА центърът в хотела предлага фитнес зала, джакузи, различни видове бани и терапии, солариум и закрит плувен басейн. На разположение на гостите са ски училище с професионални инструктори, ски гардероб и детска ски градина. От хотела се организират походи с планински водачи. Предлагат се тенис на маса, боулинг и билярд.",
                   Category = new Category() { CategoryName = CategoryType.SkiingInBulgaria },
                   FeedingType = FeedingType.HalfBoard,
                   StartPeriod = new DateTime(2017, 10, 20),
                   EndPeriod = new DateTime(2017, 10, 30),
                   Picures = new List<Picure>()
                   {
                       new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\borovec\\b1.jpeg"},
                        new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\borovec\\b2.jpeg"},
                         new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\borovec\\b3.jpeg"},
                   },
                   Price = 620,
                   TransportType = TransportType.Bus
               });

            context.Vacations.AddOrUpdate(v => v.Id,
              new Vacation()
              {
                  VacationName = "Пампорово",
                  VacationDescription = "Петзвездният хотел “Орловец” е синоним на лукса, спокойствието и уюта в Пампорово. Намира се на 1600 метра надморска височина в центъра на курорта до сградата на Общината и срещу емблематичния хотел \"Перелик\". Хотелът разполага с 105 стаи разпределени съответно в 98 двойни стаи и 7 апартамента, някои от които с междинна врата - подходящи за семейства с деца. Интериорът и разположението им предразполагат към уединение, спокойствие и комфорт. Гостите на хотела могат да се насладят на вкусните местни и интернационални ястия приготвени от нашите майстори готвачи в основния ресторант. Можете да изпиете сутрешното си кафе и да разпуснете в лоби бара, както и да посетите панорамния \"Скай\" бар, откъдето се откриват спиращи дъха гледки към кулата \"Снежанка\" и вековната борова гора. Басейнът на хотела е вътрешен, но през летните месеци е отворен с вход към лятната градина и поддържа постоянна температура от 30 градуса. SPA центърът разполага с 3 кабинета за масажи, с голямо разнообразие на предлаганите масажи и релаксиращи терапии, сауна, парна баня, тангенторна вана с възможност за хидро-масаж, душ Виши.",
                  Category = new Category() { CategoryName = CategoryType.SkiingInBulgaria },
                  FeedingType = FeedingType.HalfBoard,
                  StartPeriod = new DateTime(2017, 12, 20),
                  EndPeriod = new DateTime(2017, 12, 30),
                  Picures = new List<Picure>()
                  {
                       new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\pamporovo\\p1.jpeg"},
                        new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\pamporovo\\p2.jpeg"},
                         new Picure() {PictureSourse = "\\Content\\images\\skiing\\bulgaria\\pamporovo\\p3.jpeg"},
                  },
                  Price = 700,
                  TransportType = TransportType.Bus
              });

            context.Vacations.AddOrUpdate(v => v.Id,
             new Vacation()
             {
                 VacationName = "Черна Гора",
                 VacationDescription = "5-звездният Splendid Conference Spa Resort предлага комфорт и удобство независимо дали пътувате поради бизнес или ваканция в Будва. Гостите ще изживеят незабравим престой в хотела, благодарение на множеството удобства, които той предлага. В хотела са налични безплатен WiFi достъп във всички стаи, казино, 24-часова рецепция, 24-часов рум-сервиз, съоръжения за инвалиди. Стаите са оборудвани с всички удобства, необходими за добър нощен сън. В някои от тях ще бъдат намерени безжичен интернет достъп (безплатен), достъп до интернет (безжичен), събуждане, хидромасажна вана, стаи за непушачи. Починете си след дългия ден и да се възползвайте от гореща вана, частен плаж, фитнес зала,сауна, открит басейн. Splendid Conference Spa Resort е готов да удовлетвори Вашите нужди с помощта на надеждния си и професионален персонал.",
                 Category = new Category() { CategoryName = CategoryType.SeaAbroad },
                 FeedingType = FeedingType.HalfBoard,
                 StartPeriod = new DateTime(2017, 06, 10),
                 EndPeriod = new DateTime(2017, 06, 17),
                 Picures = new List<Picure>()
                 {
                       new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\ChernaGora\\BIG_2(2203)_147974071879221.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\ChernaGora\\BIG_budv star grad_149061333881122.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\ChernaGora\\BIG_Budva-01_149061333881122.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\ChernaGora\\BIG_Old-town-Budva_149061333881122.jpg"}
                 },
                 Price = 2400,
                 TransportType = TransportType.Airplane
             });
            context.Vacations.AddOrUpdate(v => v.Id,
            new Vacation()
            {
                VacationName = "Черна Гора",
                VacationDescription = "Radisson Blu Resort & Spa Dubrovnik Sun Gardens се намира на плажа в хърватския морски курорт Дубровник, недалеч от историческия център на града. Хотелският комплекс разполага с апартаменти, стаи и вили. Всички помещения са с тераса или балкон, а повечето са с гледка към Средиземно море. Стандартните удобства в стаите включват минибар, високоскоростна безжична интернет връзка, сейф, пособия за приготвяне на топли напитки, телевизор с платени и сателитни програми. За удобство на гостите в баните са налични сешоар и тоалетни принадлежности. В някои помещения за настаняване има кухненски бокс, трапезария и дневна зона. При поискване се предоставят за ползване дъска и ютия за гладене. Денонощно работеща рецепция се грижи за престоя на гостите. Спортен център с фитнес зала, басейни за деца и възрастни, тераса за слънчеви бани са част от съоръженията, предвидени за свободното време. Малките гости и родителите им могат да разчитат на детски клуб и детегледачка. Хотелът предлага автомобили, велосипеди и плавателни под наем, туристическа информация, транспорт с лодка до Стария град, организиране на екскурзии и трансфери от и до летището.",
                Category = new Category() { CategoryName = CategoryType.SeaAbroad },
                FeedingType = FeedingType.Fullbase,
                StartPeriod = new DateTime(2017, 07, 10),
                EndPeriod = new DateTime(2017, 07, 17),
                Picures = new List<Picure>()
                {
                       new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\dubrovnik\\BIG_cavtat1_147931309479671.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\dubrovnik\\BIG_croatia_dubrovnik_25_147931309479671.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\abroadSea\\dubrovnik\\BIG_Slider-Dubrovnik-2.jpg"}
                },
                Price = 1800,
                TransportType = TransportType.Bus
            });

            context.Vacations.AddOrUpdate(v => v.Id,
           new Vacation()
           {
               VacationName = "Албена",
               VacationDescription = "Петзвездният хотел Фламинго е част от комплекс Фламинго, разположен на търговската улица в централната част на морския курорт Албена, близо до плажа. Хотелът разполага с гараж и паркинг, магазини, арт галерия и стая за съхранение на багаж. За удобството на гостите рецепцията е на разположение денонощно. Хотелските услуги предоставят възможности за ползване на сейф на рецепцията, пералня на самообслужване, румсървиз и автомобили под наем. Гостите на хотела могат да релаксират в СПА центъра на комплекса, който предоставя салон за красота, релакс процедури, занимания по йога и китайска гимнастика и уред за отслабване. За любителите на активния спорт са предвидени фитнес и скуош зали. Деловите гости могат да се възползват от бизнес услуги и пет напълно оборудвани конферентни зали с различен капацитет. На територията на хотела се намират воден парк на открито и закрит басейн. За малките гости са осигурени детски басейн, детска площадка и детегледачка при поискване. Хотелската база на Фламинго включва апартаменти, мезонети, студиа, единични и двойни стаи. Всички стаи имат балкон и са оборудвани с мини бар, електронно заключване, телефон, телевизор с кабелни програми, сейф и сешоар.",
               Category = new Category() { CategoryName = CategoryType.BlackSea },
               FeedingType = FeedingType.Fullbase,
               StartPeriod = new DateTime(2017, 07, 01),
               EndPeriod = new DateTime(2017, 07, 08),
               Picures = new List<Picure>()
               {
                       new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\2247940.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\2352012.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\albena\\19255948.jpg"}
               },
               Price = 1100,
               TransportType = TransportType.Bus
           });

            context.Vacations.AddOrUpdate(v => v.Id,
          new Vacation()
          {
              VacationName = "Несебър",
              VacationDescription = "Melia Nesebar Mare е четиризвезден хотел, който се намира в стария град на Несебър, недалеч от центъра, в непосредствена близост до плажа и на 35 километра от Бургас. Хотелът работи на принципа All Inclusive. Атракция му е основният ресторант, в който сутрин и вечер се организира интерактивно готварско шоу, включващо приготвяне на храната на живо пред публика от гостите на хотела. А-ла-карт ресторантът на хотела предлага меню с ястия от интернационалната кухня. Лоби барът на хотела и рецепцията са на разположение денонощно. Достъпен за гостите е басейн с безплатни чадъри и шезлонги, а барът при басейна работи през целия ден. За удобството на почиващите, хотел Melia Nesebar Mare предлага паркинг, интернет клуб, лекарски кабинет, дискотека и бюро за обмяна на валута. Хотелът разполага с 247 двойни стаи, 46 фамилни стаи и 4 апартамента. Всички стаи имат балкон, а някои от тях са с панорамен морски изглед. Стаите са оборудвани с климатична система, сейф, телевизор със сателитни програми и минибар с безплатна минерална вода. За най-малките гости на хотела са предвидени детски клуб, детски басейн и пързалки. Гостите могат да релаксират в СПА център, който предлага разнообразни услуги.",
              Category = new Category() { CategoryName = CategoryType.BlackSea },
              FeedingType = FeedingType.HalfBoard,
              StartPeriod = new DateTime(2017, 06, 01),
              EndPeriod = new DateTime(2017, 06, 05),
              Picures = new List<Picure>()
              {
                       new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\nesebar\\nes1.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\nesebar\\nes2.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\nesebar\\nes3.jpg"}
              },
              Price = 750,
              TransportType = TransportType.Bus
          });

            context.Vacations.AddOrUpdate(v => v.Id,
         new Vacation()
         {
             VacationName = "Свети Влас",
             VacationDescription = "Със своето уникално разположение, хотел \"Сий Уинд\" дава възможност да се насладите на великолепна гледка към морето от всички апартаменти. Комплексът се състои от студиа с една и две спални и няколко VIP апартамента. За вашето удобство: басейн с детски сектор, детска площадка, паркинг, сауна, фитнес, магазини, закрит басейн, денонощна охрана, три панорамни лифта.",
             Category = new Category() { CategoryName = CategoryType.BlackSea },
             FeedingType = FeedingType.Breakfast,
             StartPeriod = new DateTime(2017, 06, 15),
             EndPeriod = new DateTime(2017, 06, 20),
             Picures = new List<Picure>()
             {
                       new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\sveti vlas\\26065411.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\sveti vlas\\48413987.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\Seaholidays\\BulgariaSea\\sveti vlas\\48413993.jpg"}
             },
             Price = 810,
             TransportType = TransportType.Bus
         });

            context.Vacations.AddOrUpdate(v => v.Id,
        new Vacation()
        {
            VacationName = "Чехия",
            VacationDescription = "Grandhotel Zvon се намира в Южна Бохемия, в центъра на град České Budějovice и в близост до туристическите му забележителности. На територията на хотела работи ресторант Gourmet Symphony, в който се предлагат ястия на австрийската и регионалната кулинарии, като продуктите, с които се приготвят са предимно местни. Pilsner Urquell Original е друго заведение в хотела, където посетителите могат да седнат с приятели на питие с бирени мезета. Банкетен салон и зала за срещи са на разположение на деловите гости. Помещенията са с различна площ и капацитет, а посетителите могат да разчитат на наличната презентационна техника. Персоналът на хотела предлага услугите на кетъринг, както и пакетни бизнес програми. За настаняване на гости са предвидени стаи и апартаменти, разпределени в няколко категории. Те са стандартно оборудвани с минибар, сейф за съхранение на ценности, телефон с директно избиране и телевизор с платени канали. Допълнително удобство създава осигурената връзка с интернет и самостоятелен санитарен възел.",
            Category = new Category() { CategoryName = CategoryType.Others },
            FeedingType = FeedingType.Breakfast,
            StartPeriod = new DateTime(2017, 05, 15),
            EndPeriod = new DateTime(2017, 05, 20),
            Picures = new List<Picure>()
            {
                       new Picure() {PictureSourse = "\\Content\\images\\others\\chehia\\c1.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\others\\chehia\\c2.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\others\\chehia\\c3.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\others\\chehia\\c4.jpg"}
            },
            Price = 1560,
            TransportType = TransportType.Airplane
        });

            context.Vacations.AddOrUpdate(v => v.Id,
       new Vacation()
       {
           VacationName = "Холандия",
           VacationDescription = "Отседнете в Hotel Nhow Rotterdam, за да откриете чудесата на Ротердам. Хотелът предлага широка гама от удобства и развлечения, за да се гарантира прекрасния Ви престой. Съоръжения като 24-часова рецепция, съоръжения за инвалиди, експресно настаняване/напускане, съхраняване на багаж, Wi-Fi връзка в общите части са лесно достъпни за Ваше удоволствие. Всяка стая е елегантно обзаведена и оборудвана с изкусни удобства. Възстановете се след ден прекаран в разглеждане на забележителности всред комфорта на Вашата стая, или се възползвате от съоръженията за отдих в хотела като фитнес зала.  Hotel Nhow Rotterdam съчетава топло гостоприемство с прекрасна атмосфера, за да направи престоя Ви в Ротердам незабравим.",
           Category = new Category() { CategoryName = CategoryType.Others },
           FeedingType = FeedingType.Breakfast,
           StartPeriod = new DateTime(2017, 05, 15),
           EndPeriod = new DateTime(2017, 05, 20),
           Picures = new List<Picure>()
           {
                       new Picure() {PictureSourse = "\\Content\\images\\others\\holand\\h1.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\others\\holand\\h2.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\others\\holand\\h3.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\others\\holand\\h4.jpg"}
           },
           Price = 1940,
           TransportType = TransportType.Airplane
       });

           context.Vacations.AddOrUpdate(v => v.Id,
           new Vacation()
            {
                VacationName = "Кападокия",
                VacationDescription = "Отседнете в Miras Hotel Cappadocia, за да откриете чудесата на Кападокия. Хотелът разполага с широка гама от съоръжения, за да направи престоя Ви едно приятно изживяване. За удобството на гостите се предлагат следните неща 24-часова рецепция, експресно настаняване/напускане, съхраняване на багаж, Wi-Fi връзка в общите части, паркиране на автомобили. Комфортните стаи гарантират добър нощен сън с помощта на удобства в някои от тях като безжичен интернет достъп (безплатен), събуждане, хидромасажна вана, стаи за непушачи, отопление. Починете си след дългия ден и да се възползвайте от гореща вана, открит басейн, масаж. Без значение какви са причините за Вашето посещениев Кападокия, Miras Hotel Cappadocia ще Ви накара да се почувствате като у дома.",
                Category = new Category() { CategoryName = CategoryType.Others },
                FeedingType = FeedingType.Fullbase,
                StartPeriod = new DateTime(2017, 07, 20),
                EndPeriod = new DateTime(2017, 07, 24),
                Picures = new List<Picure>()
           {
                       new Picure() {PictureSourse = "\\Content\\images\\others\\kapadokia\\k1.jpg"},
                        new Picure() {PictureSourse = "\\Content\\images\\others\\kapadokia\\k2.jpg"},
                         new Picure() {PictureSourse = "\\Content\\images\\others\\kapadokia\\k3.jpg"}
           },
                Price = 1420,
                TransportType = TransportType.Airplane
            });

            context.SaveChanges();
        }
    }
}
