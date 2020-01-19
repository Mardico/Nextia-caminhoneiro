using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Caminhoneiro.Entidade
{
    public class ApoliceDadosBeneficiario
    {
        public ApoliceDadosBeneficiario()
        {
            ListaBeneficiario();
        }
        public static List<ApoliceDadosBeneficiarioDTO> _Itens = null;
        public static List<ApoliceDadosBeneficiarioDTO> Itens() { return _Itens; }
        internal void ListaBeneficiario()
        {
            _Itens = new List<ApoliceDadosBeneficiarioDTO>() {
                    new ApoliceDadosBeneficiarioDTO  { Id = 0, NDocumento = "00000076622", Parentesco = "Cônjuje", Nome = "Brenden L. Coleman", DataNasc = DateTime.ParseExact("07/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 3, NDocumento = "00000072778", Parentesco = "Filho(s)", Nome = "Derek G. Browning", DataNasc = DateTime.ParseExact("23/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 6, NDocumento = "00000071217", Parentesco = "Cônjuje", Nome = "Ina X. Simmons", DataNasc = DateTime.ParseExact("22/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 9, NDocumento = "00000078392", Parentesco = "Cônjuje", Nome = "Denton U. House", DataNasc = DateTime.ParseExact("12/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 12, NDocumento = "00000073764", Parentesco = "Filho(s)", Nome = "Naomi L. Hoover", DataNasc = DateTime.ParseExact("11/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 15, NDocumento = "00000070538", Parentesco = "Filho(s)", Nome = "Conan E. Tyson", DataNasc = DateTime.ParseExact("10/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 18, NDocumento = "00000071625", Parentesco = "Cônjuje", Nome = "Orli B. Potts", DataNasc = DateTime.ParseExact("16/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 21, NDocumento = "00000070393", Parentesco = "Cônjuje", Nome = "Kennedy K. Potts", DataNasc = DateTime.ParseExact("09/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 24, NDocumento = "00000074066", Parentesco = "Filho(s)", Nome = "Desirae V. Carey", DataNasc = DateTime.ParseExact("30/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 27, NDocumento = "00000079297", Parentesco = "Filho(s)", Nome = "Lacota I. Wade", DataNasc = DateTime.ParseExact("02/07/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 30, NDocumento = "00000072994", Parentesco = "Cônjuje", Nome = "Desirae Y. Contreras", DataNasc = DateTime.ParseExact("27/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 33, NDocumento = "00000070427", Parentesco = "Cônjuje", Nome = "Nita Y. Harper", DataNasc = DateTime.ParseExact("08/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 36, NDocumento = "00000078089", Parentesco = "Cônjuje", Nome = "Sawyer S. Jacobs", DataNasc = DateTime.ParseExact("14/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 39, NDocumento = "00000073006", Parentesco = "Filho(s)", Nome = "Miranda S. Emerson", DataNasc = DateTime.ParseExact("31/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 42, NDocumento = "00000078630", Parentesco = "Cônjuje", Nome = "Illiana U. Owen", DataNasc = DateTime.ParseExact("29/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 45, NDocumento = "00000072075", Parentesco = "Filho(s)", Nome = "Mariko J. Hunter", DataNasc = DateTime.ParseExact("15/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 48, NDocumento = "00000074900", Parentesco = "Filho(s)", Nome = "Allen K. Dalton", DataNasc = DateTime.ParseExact("30/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 51, NDocumento = "00000070599", Parentesco = "Filho(s)", Nome = "Adam N. Mendez", DataNasc = DateTime.ParseExact("27/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 54, NDocumento = "00000078589", Parentesco = "Filho(s)", Nome = "Hoyt M. Ingram", DataNasc = DateTime.ParseExact("21/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 57, NDocumento = "00000074319", Parentesco = "Filho(s)", Nome = "Aristotle O. Mills", DataNasc = DateTime.ParseExact("20/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 60, NDocumento = "00000076134", Parentesco = "Filho(s)", Nome = "Xanthus S. Howard", DataNasc = DateTime.ParseExact("14/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 63, NDocumento = "00000074369", Parentesco = "Cônjuje", Nome = "Martena X. Edwards", DataNasc = DateTime.ParseExact("24/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 66, NDocumento = "00000070782", Parentesco = "Cônjuje", Nome = "Sylvester X. Spencer", DataNasc = DateTime.ParseExact("06/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 69, NDocumento = "00000077395", Parentesco = "Cônjuje", Nome = "Griffith D. Blake", DataNasc = DateTime.ParseExact("01/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 72, NDocumento = "00000078127", Parentesco = "Cônjuje", Nome = "Mohammad L. Marquez", DataNasc = DateTime.ParseExact("14/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 75, NDocumento = "00000075043", Parentesco = "Filho(s)", Nome = "Rylee R. Petersen", DataNasc = DateTime.ParseExact("01/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 78, NDocumento = "00000070610", Parentesco = "Cônjuje", Nome = "Ian U. Lowery", DataNasc = DateTime.ParseExact("29/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 81, NDocumento = "00000077126", Parentesco = "Cônjuje", Nome = "Hayden K. Peters", DataNasc = DateTime.ParseExact("22/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 84, NDocumento = "00000071177", Parentesco = "Cônjuje", Nome = "Amy R. Mills", DataNasc = DateTime.ParseExact("23/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 87, NDocumento = "00000072377", Parentesco = "Cônjuje", Nome = "Erasmus M. Gillespie", DataNasc = DateTime.ParseExact("10/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 90, NDocumento = "00000072157", Parentesco = "Filho(s)", Nome = "Zelenia K. Vaughan", DataNasc = DateTime.ParseExact("28/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 93, NDocumento = "00000071481", Parentesco = "Cônjuje", Nome = "Chase J. Schwartz", DataNasc = DateTime.ParseExact("30/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 96, NDocumento = "00000078880", Parentesco = "Cônjuje", Nome = "Wylie O. Horton", DataNasc = DateTime.ParseExact("08/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 99, NDocumento = "00000073503", Parentesco = "Filho(s)", Nome = "Fitzgerald A. Todd", DataNasc = DateTime.ParseExact("10/06/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 102, NDocumento = "00000077677", Parentesco = "Filho(s)", Nome = "Justine J. Faulkner", DataNasc = DateTime.ParseExact("01/10/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 105, NDocumento = "00000074453", Parentesco = "Filho(s)", Nome = "Stuart F. Ortega", DataNasc = DateTime.ParseExact("02/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 108, NDocumento = "00000076396", Parentesco = "Filho(s)", Nome = "Karyn E. Sloan", DataNasc = DateTime.ParseExact("20/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 111, NDocumento = "00000073301", Parentesco = "Filho(s)", Nome = "Adara E. Cohen", DataNasc = DateTime.ParseExact("01/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 114, NDocumento = "00000070724", Parentesco = "Filho(s)", Nome = "Jared H. Moore", DataNasc = DateTime.ParseExact("04/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 117, NDocumento = "00000075656", Parentesco = "Filho(s)", Nome = "Sonia Y. Russell", DataNasc = DateTime.ParseExact("20/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 120, NDocumento = "00000079626", Parentesco = "Filho(s)", Nome = "Erasmus V. Snider", DataNasc = DateTime.ParseExact("23/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 123, NDocumento = "00000075727", Parentesco = "Filho(s)", Nome = "Mikayla A. Berg", DataNasc = DateTime.ParseExact("16/10/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 126, NDocumento = "00000071552", Parentesco = "Filho(s)", Nome = "Alexa T. Clemons", DataNasc = DateTime.ParseExact("06/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 129, NDocumento = "00000071748", Parentesco = "Filho(s)", Nome = "Garrison K. Mcintosh", DataNasc = DateTime.ParseExact("31/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 132, NDocumento = "00000070727", Parentesco = "Filho(s)", Nome = "Drake R. Noble", DataNasc = DateTime.ParseExact("11/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 135, NDocumento = "00000071903", Parentesco = "Filho(s)", Nome = "Vernon T. Huber", DataNasc = DateTime.ParseExact("16/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 138, NDocumento = "00000071588", Parentesco = "Filho(s)", Nome = "Charde J. Delgado", DataNasc = DateTime.ParseExact("30/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 141, NDocumento = "00000078460", Parentesco = "Filho(s)", Nome = "Lani M. Hurst", DataNasc = DateTime.ParseExact("29/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 144, NDocumento = "00000079227", Parentesco = "Cônjuje", Nome = "Giselle J. Atkinson", DataNasc = DateTime.ParseExact("17/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 147, NDocumento = "00000072541", Parentesco = "Filho(s)", Nome = "Shad K. Ayers", DataNasc = DateTime.ParseExact("12/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 150, NDocumento = "00000078579", Parentesco = "Cônjuje", Nome = "Chaney I. Armstrong", DataNasc = DateTime.ParseExact("30/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 153, NDocumento = "00000079300", Parentesco = "Cônjuje", Nome = "Whitney S. Ford", DataNasc = DateTime.ParseExact("25/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 156, NDocumento = "00000071652", Parentesco = "Cônjuje", Nome = "Kelly K. Hubbard", DataNasc = DateTime.ParseExact("21/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 159, NDocumento = "00000074121", Parentesco = "Filho(s)", Nome = "Allegra O. Buck", DataNasc = DateTime.ParseExact("13/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 162, NDocumento = "00000076952", Parentesco = "Cônjuje", Nome = "Josiah J. Harvey", DataNasc = DateTime.ParseExact("05/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 165, NDocumento = "00000075778", Parentesco = "Cônjuje", Nome = "John X. Casey", DataNasc = DateTime.ParseExact("09/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 168, NDocumento = "00000077783", Parentesco = "Cônjuje", Nome = "Dakota B. Odonnell", DataNasc = DateTime.ParseExact("22/09/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 171, NDocumento = "00000075287", Parentesco = "Cônjuje", Nome = "Samson X. Britt", DataNasc = DateTime.ParseExact("22/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 174, NDocumento = "00000077264", Parentesco = "Cônjuje", Nome = "Emmanuel Q. Burks", DataNasc = DateTime.ParseExact("18/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 177, NDocumento = "00000077668", Parentesco = "Cônjuje", Nome = "Fleur U. Webb", DataNasc = DateTime.ParseExact("05/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 180, NDocumento = "00000070188", Parentesco = "Filho(s)", Nome = "Austin E. Snow", DataNasc = DateTime.ParseExact("17/01/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 183, NDocumento = "00000075857", Parentesco = "Cônjuje", Nome = "Lenore J. Bean", DataNasc = DateTime.ParseExact("19/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 186, NDocumento = "00000072777", Parentesco = "Filho(s)", Nome = "Darius C. Schultz", DataNasc = DateTime.ParseExact("27/03/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 189, NDocumento = "00000073218", Parentesco = "Filho(s)", Nome = "Cora U. Allison", DataNasc = DateTime.ParseExact("03/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 192, NDocumento = "00000074598", Parentesco = "Filho(s)", Nome = "Yasir K. Mcleod", DataNasc = DateTime.ParseExact("21/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 195, NDocumento = "00000077517", Parentesco = "Cônjuje", Nome = "Paul R. Montgomery", DataNasc = DateTime.ParseExact("19/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 198, NDocumento = "00000079608", Parentesco = "Filho(s)", Nome = "Dalton N. Hensley", DataNasc = DateTime.ParseExact("26/08/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 201, NDocumento = "00000074952", Parentesco = "Filho(s)", Nome = "Stella E. Dodson", DataNasc = DateTime.ParseExact("29/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 204, NDocumento = "00000077580", Parentesco = "Filho(s)", Nome = "Xaviera D. Berger", DataNasc = DateTime.ParseExact("18/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 207, NDocumento = "00000075492", Parentesco = "Cônjuje", Nome = "Keith A. Waller", DataNasc = DateTime.ParseExact("21/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 210, NDocumento = "00000070350", Parentesco = "Cônjuje", Nome = "Inez R. Kennedy", DataNasc = DateTime.ParseExact("22/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 213, NDocumento = "00000075542", Parentesco = "Cônjuje", Nome = "Jordan W. Callahan", DataNasc = DateTime.ParseExact("03/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 216, NDocumento = "00000073669", Parentesco = "Cônjuje", Nome = "Adara E. Bernard", DataNasc = DateTime.ParseExact("10/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 219, NDocumento = "00000079229", Parentesco = "Filho(s)", Nome = "Mari A. Mcneil", DataNasc = DateTime.ParseExact("02/12/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 222, NDocumento = "00000076741", Parentesco = "Cônjuje", Nome = "Moses A. Mann", DataNasc = DateTime.ParseExact("03/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 225, NDocumento = "00000070150", Parentesco = "Cônjuje", Nome = "Ayanna Y. Buck", DataNasc = DateTime.ParseExact("22/11/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 228, NDocumento = "00000072096", Parentesco = "Filho(s)", Nome = "Brittany G. Rowe", DataNasc = DateTime.ParseExact("09/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 231, NDocumento = "00000074291", Parentesco = "Cônjuje", Nome = "Wayne E. Rasmussen", DataNasc = DateTime.ParseExact("30/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 234, NDocumento = "00000077192", Parentesco = "Filho(s)", Nome = "Luke M. Rios", DataNasc = DateTime.ParseExact("02/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 237, NDocumento = "00000078404", Parentesco = "Filho(s)", Nome = "Stella R. Ray", DataNasc = DateTime.ParseExact("02/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 240, NDocumento = "00000073941", Parentesco = "Filho(s)", Nome = "Samson X. Kline", DataNasc = DateTime.ParseExact("16/02/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 243, NDocumento = "00000077454", Parentesco = "Filho(s)", Nome = "Kane N. Singleton", DataNasc = DateTime.ParseExact("06/10/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 246, NDocumento = "00000076041", Parentesco = "Filho(s)", Nome = "Jerry Z. Velez", DataNasc = DateTime.ParseExact("07/11/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 249, NDocumento = "00000073145", Parentesco = "Filho(s)", Nome = "Jaden F. Melton", DataNasc = DateTime.ParseExact("21/06/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 252, NDocumento = "00000076717", Parentesco = "Cônjuje", Nome = "Aileen C. Ortega", DataNasc = DateTime.ParseExact("26/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 255, NDocumento = "00000073070", Parentesco = "Cônjuje", Nome = "Mia S. Winters", DataNasc = DateTime.ParseExact("28/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 258, NDocumento = "00000073701", Parentesco = "Cônjuje", Nome = "Wesley A. Browning", DataNasc = DateTime.ParseExact("20/03/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 261, NDocumento = "00000070951", Parentesco = "Filho(s)", Nome = "Regan M. Pruitt", DataNasc = DateTime.ParseExact("12/09/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 264, NDocumento = "00000070702", Parentesco = "Filho(s)", Nome = "Timon Q. Holmes", DataNasc = DateTime.ParseExact("15/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 267, NDocumento = "00000079690", Parentesco = "Cônjuje", Nome = "Jasmine F. Carey", DataNasc = DateTime.ParseExact("11/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 270, NDocumento = "00000072491", Parentesco = "Cônjuje", Nome = "Regina B. Conley", DataNasc = DateTime.ParseExact("24/07/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 273, NDocumento = "00000071473", Parentesco = "Cônjuje", Nome = "Jorden D. Wheeler", DataNasc = DateTime.ParseExact("20/01/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 276, NDocumento = "00000075624", Parentesco = "Filho(s)", Nome = "Nehru K. Dalton", DataNasc = DateTime.ParseExact("22/05/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 279, NDocumento = "00000071928", Parentesco = "Filho(s)", Nome = "Irene V. Hill", DataNasc = DateTime.ParseExact("26/02/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 282, NDocumento = "00000074835", Parentesco = "Cônjuje", Nome = "Evelyn S. Hardin", DataNasc = DateTime.ParseExact("17/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 285, NDocumento = "00000078741", Parentesco = "Cônjuje", Nome = "Sawyer A. Avila", DataNasc = DateTime.ParseExact("05/12/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 288, NDocumento = "00000079772", Parentesco = "Filho(s)", Nome = "Oleg M. Petty", DataNasc = DateTime.ParseExact("03/04/2019", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 291, NDocumento = "00000073153", Parentesco = "Filho(s)", Nome = "Rachel E. Foley", DataNasc = DateTime.ParseExact("02/05/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 294, NDocumento = "00000070062", Parentesco = "Filho(s)", Nome = "Akeem Y. Russell", DataNasc = DateTime.ParseExact("15/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) },
                    new ApoliceDadosBeneficiarioDTO   { Id = 297, NDocumento = "00000077942", Parentesco = "Cônjuje", Nome = "Rajah X. Sweet", DataNasc = DateTime.ParseExact("19/04/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture) }
                };

        }
    }
}
