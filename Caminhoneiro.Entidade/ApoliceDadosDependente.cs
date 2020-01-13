using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Caminhoneiro.Entidade
{
    public class ApoliceDadosDependente
    {
        public ApoliceDadosDependente()
        {
            ListaDependentes();
        }
        public static List<ApoliceDadosDependenteDTO> _Itens = null;
        public static List<ApoliceDadosDependenteDTO> Itens() { return _Itens; }
        internal void ListaDependentes()
        {
            _Itens = new List<ApoliceDadosDependenteDTO>() {
                    new ApoliceDadosDependenteDTO  { Id = 0, Codigo = "76622", Tipo = "Cônjuje", Nome = "Brenden L. Coleman", DataNasc = DateTime.ParseExact("07/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 3, Codigo = "72778", Tipo = "Filho(s)", Nome = "Derek G. Browning", DataNasc = DateTime.ParseExact("23/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 6, Codigo = "71217", Tipo = "Cônjuje", Nome = "Ina X. Simmons", DataNasc = DateTime.ParseExact("22/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 9, Codigo = "78392", Tipo = "Cônjuje", Nome = "Denton U. House", DataNasc = DateTime.ParseExact("12/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 12, Codigo = "73764", Tipo = "Filho(s)", Nome = "Naomi L. Hoover", DataNasc = DateTime.ParseExact("11/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 15, Codigo = "70538", Tipo = "Filho(s)", Nome = "Conan E. Tyson", DataNasc = DateTime.ParseExact("10/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 18, Codigo = "71625", Tipo = "Cônjuje", Nome = "Orli B. Potts", DataNasc = DateTime.ParseExact("16/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 21, Codigo = "70393", Tipo = "Cônjuje", Nome = "Kennedy K. Potts", DataNasc = DateTime.ParseExact("09/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 24, Codigo = "74066", Tipo = "Filho(s)", Nome = "Desirae V. Carey", DataNasc = DateTime.ParseExact("30/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 27, Codigo = "79297", Tipo = "Filho(s)", Nome = "Lacota I. Wade", DataNasc = DateTime.ParseExact("02/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 30, Codigo = "72994", Tipo = "Cônjuje", Nome = "Desirae Y. Contreras", DataNasc = DateTime.ParseExact("27/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 33, Codigo = "70427", Tipo = "Cônjuje", Nome = "Nita Y. Harper", DataNasc = DateTime.ParseExact("08/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 36, Codigo = "78089", Tipo = "Cônjuje", Nome = "Sawyer S. Jacobs", DataNasc = DateTime.ParseExact("14/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 39, Codigo = "73006", Tipo = "Filho(s)", Nome = "Miranda S. Emerson", DataNasc = DateTime.ParseExact("31/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 42, Codigo = "78630", Tipo = "Cônjuje", Nome = "Illiana U. Owen", DataNasc = DateTime.ParseExact("29/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 45, Codigo = "72075", Tipo = "Filho(s)", Nome = "Mariko J. Hunter", DataNasc = DateTime.ParseExact("15/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 48, Codigo = "74900", Tipo = "Filho(s)", Nome = "Allen K. Dalton", DataNasc = DateTime.ParseExact("30/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 51, Codigo = "70599", Tipo = "Filho(s)", Nome = "Adam N. Mendez", DataNasc = DateTime.ParseExact("27/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 54, Codigo = "78589", Tipo = "Filho(s)", Nome = "Hoyt M. Ingram", DataNasc = DateTime.ParseExact("21/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 57, Codigo = "74319", Tipo = "Filho(s)", Nome = "Aristotle O. Mills", DataNasc = DateTime.ParseExact("20/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 60, Codigo = "76134", Tipo = "Filho(s)", Nome = "Xanthus S. Howard", DataNasc = DateTime.ParseExact("14/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 63, Codigo = "74369", Tipo = "Cônjuje", Nome = "Martena X. Edwards", DataNasc = DateTime.ParseExact("24/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 66, Codigo = "70782", Tipo = "Cônjuje", Nome = "Sylvester X. Spencer", DataNasc = DateTime.ParseExact("06/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 69, Codigo = "77395", Tipo = "Cônjuje", Nome = "Griffith D. Blake", DataNasc = DateTime.ParseExact("01/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 72, Codigo = "78127", Tipo = "Cônjuje", Nome = "Mohammad L. Marquez", DataNasc = DateTime.ParseExact("14/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 75, Codigo = "75043", Tipo = "Filho(s)", Nome = "Rylee R. Petersen", DataNasc = DateTime.ParseExact("01/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 78, Codigo = "70610", Tipo = "Cônjuje", Nome = "Ian U. Lowery", DataNasc = DateTime.ParseExact("29/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 81, Codigo = "77126", Tipo = "Cônjuje", Nome = "Hayden K. Peters", DataNasc = DateTime.ParseExact("22/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 84, Codigo = "71177", Tipo = "Cônjuje", Nome = "Amy R. Mills", DataNasc = DateTime.ParseExact("23/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 87, Codigo = "72377", Tipo = "Cônjuje", Nome = "Erasmus M. Gillespie", DataNasc = DateTime.ParseExact("10/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 90, Codigo = "72157", Tipo = "Filho(s)", Nome = "Zelenia K. Vaughan", DataNasc = DateTime.ParseExact("28/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 93, Codigo = "71481", Tipo = "Cônjuje", Nome = "Chase J. Schwartz", DataNasc = DateTime.ParseExact("30/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 96, Codigo = "78880", Tipo = "Cônjuje", Nome = "Wylie O. Horton", DataNasc = DateTime.ParseExact("08/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 99, Codigo = "73503", Tipo = "Filho(s)", Nome = "Fitzgerald A. Todd", DataNasc = DateTime.ParseExact("10/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 102, Codigo = "77677", Tipo = "Filho(s)", Nome = "Justine J. Faulkner", DataNasc = DateTime.ParseExact("01/10/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 105, Codigo = "74453", Tipo = "Filho(s)", Nome = "Stuart F. Ortega", DataNasc = DateTime.ParseExact("02/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 108, Codigo = "76396", Tipo = "Filho(s)", Nome = "Karyn E. Sloan", DataNasc = DateTime.ParseExact("20/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 111, Codigo = "73301", Tipo = "Filho(s)", Nome = "Adara E. Cohen", DataNasc = DateTime.ParseExact("01/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 114, Codigo = "70724", Tipo = "Filho(s)", Nome = "Jared H. Moore", DataNasc = DateTime.ParseExact("04/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 117, Codigo = "75656", Tipo = "Filho(s)", Nome = "Sonia Y. Russell", DataNasc = DateTime.ParseExact("20/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 120, Codigo = "79626", Tipo = "Filho(s)", Nome = "Erasmus V. Snider", DataNasc = DateTime.ParseExact("23/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 123, Codigo = "75727", Tipo = "Filho(s)", Nome = "Mikayla A. Berg", DataNasc = DateTime.ParseExact("16/10/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 126, Codigo = "71552", Tipo = "Filho(s)", Nome = "Alexa T. Clemons", DataNasc = DateTime.ParseExact("06/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 129, Codigo = "71748", Tipo = "Filho(s)", Nome = "Garrison K. Mcintosh", DataNasc = DateTime.ParseExact("31/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 132, Codigo = "70727", Tipo = "Filho(s)", Nome = "Drake R. Noble", DataNasc = DateTime.ParseExact("11/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 135, Codigo = "71903", Tipo = "Filho(s)", Nome = "Vernon T. Huber", DataNasc = DateTime.ParseExact("16/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 138, Codigo = "71588", Tipo = "Filho(s)", Nome = "Charde J. Delgado", DataNasc = DateTime.ParseExact("30/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 141, Codigo = "78460", Tipo = "Filho(s)", Nome = "Lani M. Hurst", DataNasc = DateTime.ParseExact("29/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 144, Codigo = "79227", Tipo = "Cônjuje", Nome = "Giselle J. Atkinson", DataNasc = DateTime.ParseExact("17/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 147, Codigo = "72541", Tipo = "Filho(s)", Nome = "Shad K. Ayers", DataNasc = DateTime.ParseExact("12/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 150, Codigo = "78579", Tipo = "Cônjuje", Nome = "Chaney I. Armstrong", DataNasc = DateTime.ParseExact("30/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 153, Codigo = "79300", Tipo = "Cônjuje", Nome = "Whitney S. Ford", DataNasc = DateTime.ParseExact("25/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 156, Codigo = "71652", Tipo = "Cônjuje", Nome = "Kelly K. Hubbard", DataNasc = DateTime.ParseExact("21/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 159, Codigo = "74121", Tipo = "Filho(s)", Nome = "Allegra O. Buck", DataNasc = DateTime.ParseExact("13/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 162, Codigo = "76952", Tipo = "Cônjuje", Nome = "Josiah J. Harvey", DataNasc = DateTime.ParseExact("05/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 165, Codigo = "75778", Tipo = "Cônjuje", Nome = "John X. Casey", DataNasc = DateTime.ParseExact("09/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 168, Codigo = "77783", Tipo = "Cônjuje", Nome = "Dakota B. Odonnell", DataNasc = DateTime.ParseExact("22/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 171, Codigo = "75287", Tipo = "Cônjuje", Nome = "Samson X. Britt", DataNasc = DateTime.ParseExact("22/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 174, Codigo = "77264", Tipo = "Cônjuje", Nome = "Emmanuel Q. Burks", DataNasc = DateTime.ParseExact("18/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 177, Codigo = "77668", Tipo = "Cônjuje", Nome = "Fleur U. Webb", DataNasc = DateTime.ParseExact("05/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 180, Codigo = "70188", Tipo = "Filho(s)", Nome = "Austin E. Snow", DataNasc = DateTime.ParseExact("17/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 183, Codigo = "75857", Tipo = "Cônjuje", Nome = "Lenore J. Bean", DataNasc = DateTime.ParseExact("19/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 186, Codigo = "72777", Tipo = "Filho(s)", Nome = "Darius C. Schultz", DataNasc = DateTime.ParseExact("27/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 189, Codigo = "73218", Tipo = "Filho(s)", Nome = "Cora U. Allison", DataNasc = DateTime.ParseExact("03/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 192, Codigo = "74598", Tipo = "Filho(s)", Nome = "Yasir K. Mcleod", DataNasc = DateTime.ParseExact("21/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 195, Codigo = "77517", Tipo = "Cônjuje", Nome = "Paul R. Montgomery", DataNasc = DateTime.ParseExact("19/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 198, Codigo = "79608", Tipo = "Filho(s)", Nome = "Dalton N. Hensley", DataNasc = DateTime.ParseExact("26/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 201, Codigo = "74952", Tipo = "Filho(s)", Nome = "Stella E. Dodson", DataNasc = DateTime.ParseExact("29/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 204, Codigo = "77580", Tipo = "Filho(s)", Nome = "Xaviera D. Berger", DataNasc = DateTime.ParseExact("18/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 207, Codigo = "75492", Tipo = "Cônjuje", Nome = "Keith A. Waller", DataNasc = DateTime.ParseExact("21/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 210, Codigo = "70350", Tipo = "Cônjuje", Nome = "Inez R. Kennedy", DataNasc = DateTime.ParseExact("22/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 213, Codigo = "75542", Tipo = "Cônjuje", Nome = "Jordan W. Callahan", DataNasc = DateTime.ParseExact("03/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 216, Codigo = "73669", Tipo = "Cônjuje", Nome = "Adara E. Bernard", DataNasc = DateTime.ParseExact("10/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 219, Codigo = "79229", Tipo = "Filho(s)", Nome = "Mari A. Mcneil", DataNasc = DateTime.ParseExact("02/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 222, Codigo = "76741", Tipo = "Cônjuje", Nome = "Moses A. Mann", DataNasc = DateTime.ParseExact("03/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 225, Codigo = "70150", Tipo = "Cônjuje", Nome = "Ayanna Y. Buck", DataNasc = DateTime.ParseExact("22/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 228, Codigo = "72096", Tipo = "Filho(s)", Nome = "Brittany G. Rowe", DataNasc = DateTime.ParseExact("09/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 231, Codigo = "74291", Tipo = "Cônjuje", Nome = "Wayne E. Rasmussen", DataNasc = DateTime.ParseExact("30/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 234, Codigo = "77192", Tipo = "Filho(s)", Nome = "Luke M. Rios", DataNasc = DateTime.ParseExact("02/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 237, Codigo = "78404", Tipo = "Filho(s)", Nome = "Stella R. Ray", DataNasc = DateTime.ParseExact("02/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 240, Codigo = "73941", Tipo = "Filho(s)", Nome = "Samson X. Kline", DataNasc = DateTime.ParseExact("16/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 243, Codigo = "77454", Tipo = "Filho(s)", Nome = "Kane N. Singleton", DataNasc = DateTime.ParseExact("06/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 246, Codigo = "76041", Tipo = "Filho(s)", Nome = "Jerry Z. Velez", DataNasc = DateTime.ParseExact("07/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 249, Codigo = "73145", Tipo = "Filho(s)", Nome = "Jaden F. Melton", DataNasc = DateTime.ParseExact("21/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 252, Codigo = "76717", Tipo = "Cônjuje", Nome = "Aileen C. Ortega", DataNasc = DateTime.ParseExact("26/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 255, Codigo = "73070", Tipo = "Cônjuje", Nome = "Mia S. Winters", DataNasc = DateTime.ParseExact("28/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 258, Codigo = "73701", Tipo = "Cônjuje", Nome = "Wesley A. Browning", DataNasc = DateTime.ParseExact("20/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 261, Codigo = "70951", Tipo = "Filho(s)", Nome = "Regan M. Pruitt", DataNasc = DateTime.ParseExact("12/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 264, Codigo = "70702", Tipo = "Filho(s)", Nome = "Timon Q. Holmes", DataNasc = DateTime.ParseExact("15/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 267, Codigo = "79690", Tipo = "Cônjuje", Nome = "Jasmine F. Carey", DataNasc = DateTime.ParseExact("11/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 270, Codigo = "72491", Tipo = "Cônjuje", Nome = "Regina B. Conley", DataNasc = DateTime.ParseExact("24/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 273, Codigo = "71473", Tipo = "Cônjuje", Nome = "Jorden D. Wheeler", DataNasc = DateTime.ParseExact("20/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 276, Codigo = "75624", Tipo = "Filho(s)", Nome = "Nehru K. Dalton", DataNasc = DateTime.ParseExact("22/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 279, Codigo = "71928", Tipo = "Filho(s)", Nome = "Irene V. Hill", DataNasc = DateTime.ParseExact("26/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 282, Codigo = "74835", Tipo = "Cônjuje", Nome = "Evelyn S. Hardin", DataNasc = DateTime.ParseExact("17/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 285, Codigo = "78741", Tipo = "Cônjuje", Nome = "Sawyer A. Avila", DataNasc = DateTime.ParseExact("05/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 288, Codigo = "79772", Tipo = "Filho(s)", Nome = "Oleg M. Petty", DataNasc = DateTime.ParseExact("03/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 291, Codigo = "73153", Tipo = "Filho(s)", Nome = "Rachel E. Foley", DataNasc = DateTime.ParseExact("02/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 294, Codigo = "70062", Tipo = "Filho(s)", Nome = "Akeem Y. Russell", DataNasc = DateTime.ParseExact("15/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosDependenteDTO  { Id = 297, Codigo = "77942", Tipo = "Cônjuje", Nome = "Rajah X. Sweet", DataNasc = DateTime.ParseExact("19/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) }
                };

        }
    }
}
