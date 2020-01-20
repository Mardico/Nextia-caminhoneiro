using Caminhoneiro.DTO;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Caminhoneiro.Entidade
{
    public class ApoliceDadosPagamento
    {
        public ApoliceDadosPagamento()
        {
            GetApoliceDadosPagamento();
        }
        internal static List<ApoliceDadosPagamentoDTO> _Itens = null;
        public static List<ApoliceDadosPagamentoDTO> Itens() { return _Itens; }
        internal void GetApoliceDadosPagamento()
        {
            _Itens = new List<ApoliceDadosPagamentoDTO>() {
                new ApoliceDadosPagamentoDTO { Id = 1, Codigo = "92865", MeioPgtoId = 0, Conta = "533807 046781 5481", NomeResponsavel = "Martena Z. Boyle", DataExpiracao = "03 / 2020", CVV = "4252", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 2, Codigo = "81731", MeioPgtoId = 1, Conta = "5185 0809 2863 8731", NomeResponsavel = "Rhiannon V. Shepherd", DataExpiracao = "05 / 2019", CVV = "9728", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 3, Codigo = "42975", MeioPgtoId = 0, Conta = "539 09830 40363 446", NomeResponsavel = "Calista O. Barrett", DataExpiracao = "15 / 02 / 2019", CVV = "6543", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 4, Codigo = "21256", MeioPgtoId = 0, Conta = "536236 827601 2178", NomeResponsavel = "Megan W. Aguilar", DataExpiracao = "07 / 2019", CVV = "6065", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 5, Codigo = "65364", MeioPgtoId = 0, Conta = "5501 8086 7935 6948", NomeResponsavel = "Nigel G. Stuart", DataExpiracao = "11 / 2020", CVV = "7161", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 6, Codigo = "58103", MeioPgtoId = 1, Conta = "5175467888496972", NomeResponsavel = "Karina V. Conner", DataExpiracao = "04 / 2019", CVV = "3316", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 7, Codigo = "26075", MeioPgtoId = 1, Conta = "545651 089508 5872", NomeResponsavel = "Noah B. Townsend", DataExpiracao = "11 / 2020", CVV = "6331", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 8, Codigo = "86770", MeioPgtoId = 0, Conta = "516372 405459 7718", NomeResponsavel = "Fallon I. Cochran", DataExpiracao = "02 / 2020", CVV = "2158", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 9, Codigo = "87292", MeioPgtoId = 0, Conta = "5593 7786 8686 9259", NomeResponsavel = "Kadeem O. Smith", DataExpiracao = "01 / 2020", CVV = "2831", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 10, Codigo = "45547", MeioPgtoId = 1, Conta = "533338 598760 0618", NomeResponsavel = "Blair O. Acevedo", DataExpiracao = "09 / 2019", CVV = "6398", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 11, Codigo = "27901", MeioPgtoId = 1, Conta = "5315 9549 5894 9700", NomeResponsavel = "Hedda H. Bray", DataExpiracao = "06 / 2019", CVV = "8471", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 12, Codigo = "37962", MeioPgtoId = 1, Conta = "5364 7749 8181 2992", NomeResponsavel = "Clementine H. Potts", DataExpiracao = "05 / 2020", CVV = "7623", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 13, Codigo = "74394", MeioPgtoId = 1, Conta = "533521 747870 5192", NomeResponsavel = "Jackson F. Clayton", DataExpiracao = "03 / 2019", CVV = "5252", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 14, Codigo = "89101", MeioPgtoId = 1, Conta = "5197665449918178", NomeResponsavel = "Bree D. Haley", DataExpiracao = "06 / 2019", CVV = "9341", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 15, Codigo = "79153", MeioPgtoId = 0, Conta = "5497768765435459", NomeResponsavel = "Davis M. Jarvis", DataExpiracao = "02 / 2019", CVV = "8663", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 16, Codigo = "17198", MeioPgtoId = 1, Conta = "548068 869598 4724", NomeResponsavel = "Dara W. Peters", DataExpiracao = "06 / 2020", CVV = "4455", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 17, Codigo = "82667", MeioPgtoId = 0, Conta = "522 16586 66489 908", NomeResponsavel = "Helen Y. Lawson", DataExpiracao = "11 / 2019", CVV = "4446", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 18, Codigo = "29876", MeioPgtoId = 1, Conta = "5349 8110 6692 6493", NomeResponsavel = "Cheryl I. Snow", DataExpiracao = "06 / 2020", CVV = "4442", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 19, Codigo = "38246", MeioPgtoId = 0, Conta = "531 98399 57818 483", NomeResponsavel = "Ava Y. Calhoun", DataExpiracao = "06 / 2019", CVV = "1243", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 20, Codigo = "50737", MeioPgtoId = 0, Conta = "5404182925179811", NomeResponsavel = "Amity S. Bright", DataExpiracao = "11 / 2020", CVV = "9881", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 21, Codigo = "00949", MeioPgtoId = 1, Conta = "5468 5809 2398 8567", NomeResponsavel = "Alika M. Dudley", DataExpiracao = "10 / 2019", CVV = "7997", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 22, Codigo = "04676", MeioPgtoId = 0, Conta = "518793 531589 1185", NomeResponsavel = "Larissa S. Bradford", DataExpiracao = "04 / 2020", CVV = "6056", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 23, Codigo = "50927", MeioPgtoId = 1, Conta = "554647 958596 3503", NomeResponsavel = "Howard J. Galloway", DataExpiracao = "07 / 2020", CVV = "5173", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 24, Codigo = "97152", MeioPgtoId = 1, Conta = "513 65636 49073 957", NomeResponsavel = "Jana G. Guzman", DataExpiracao = "05 / 2019", CVV = "6379", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 25, Codigo = "55748", MeioPgtoId = 1, Conta = "522847 833133 1994", NomeResponsavel = "Genevieve G. Riddle", DataExpiracao = "07 / 2019", CVV = "4354", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 26, Codigo = "06038", MeioPgtoId = 1, Conta = "543935 624400 1091", NomeResponsavel = "Jameson H. Salazar", DataExpiracao = "07 / 2020", CVV = "6034", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 27, Codigo = "31610", MeioPgtoId = 1, Conta = "536520 804182 3177", NomeResponsavel = "Austin K. Horn", DataExpiracao = "09 / 2019", CVV = "7570", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 28, Codigo = "29047", MeioPgtoId = 0, Conta = "550819 5684885670", NomeResponsavel = "Cadman P. Merrill", DataExpiracao = "05 / 2019", CVV = "4675", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 29, Codigo = "73797", MeioPgtoId = 0, Conta = "5479045297500908", NomeResponsavel = "Wing W. White", DataExpiracao = "01 / 2019", CVV = "3597", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 30, Codigo = "09352", MeioPgtoId = 0, Conta = "5372076206489931", NomeResponsavel = "Blythe Q. Wells", DataExpiracao = "05 / 2020", CVV = "7310", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 31, Codigo = "22641", MeioPgtoId = 1, Conta = "550097 0169293741", NomeResponsavel = "Kevin T. Greer", DataExpiracao = "07 / 2020", CVV = "8737", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 32, Codigo = "20180", MeioPgtoId = 0, Conta = "551188 212310 2214", NomeResponsavel = "Haley U. French", DataExpiracao = "01 / 2020", CVV = "7486", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 33, Codigo = "93631", MeioPgtoId = 1, Conta = "5166 3110 7451 4308", NomeResponsavel = "Latifah G. Coleman", DataExpiracao = "04 / 2019", CVV = "7960", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 34, Codigo = "87899", MeioPgtoId = 1, Conta = "559 54138 11485 775", NomeResponsavel = "Ori Q. Ewing", DataExpiracao = "12 / 2019", CVV = "2395", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 35, Codigo = "92638", MeioPgtoId = 0, Conta = "520447 2263158853", NomeResponsavel = "Xanthus S. Cooley", DataExpiracao = "10 / 2019", CVV = "6917", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 36, Codigo = "66828", MeioPgtoId = 1, Conta = "512401 8359114313", NomeResponsavel = "Mason F. Weaver", DataExpiracao = "12 / 2020", CVV = "4547", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 37, Codigo = "56104", MeioPgtoId = 1, Conta = "551973 1853329947", NomeResponsavel = "Thomas A. Hester", DataExpiracao = "05 / 2020", CVV = "6987", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 38, Codigo = "60064", MeioPgtoId = 0, Conta = "549914 1907350473", NomeResponsavel = "Clayton T. Stanley", DataExpiracao = "06 / 2019", CVV = "6758", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 39, Codigo = "64024", MeioPgtoId = 1, Conta = "510 89875 05660 355", NomeResponsavel = "Thaddeus Q. Dodson", DataExpiracao = "09 / 2020", CVV = "7973", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 40, Codigo = "66816", MeioPgtoId = 0, Conta = "558909 624804 7678", NomeResponsavel = "Regan C. Brown", DataExpiracao = "02 / 2020", CVV = "8178", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 41, Codigo = "71353", MeioPgtoId = 0, Conta = "5585055937611941", NomeResponsavel = "Keelie P. Gentry", DataExpiracao = "08 / 2019", CVV = "7889", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 42, Codigo = "17253", MeioPgtoId = 0, Conta = "512026 816550 3266", NomeResponsavel = "Vance X. Norman", DataExpiracao = "04 / 2020", CVV = "9092", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 43, Codigo = "87534", MeioPgtoId = 1, Conta = "549413 947362 4557", NomeResponsavel = "Velma C. Underwood", DataExpiracao = "05 / 2020", CVV = "3101", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 44, Codigo = "83829", MeioPgtoId = 0, Conta = "532780 6324164065", NomeResponsavel = "Brenna N. Hester", DataExpiracao = "08 / 2019", CVV = "1959", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 45, Codigo = "88087", MeioPgtoId = 0, Conta = "5300 6499 9969 3971", NomeResponsavel = "Karyn D. Levine", DataExpiracao = "08 / 2020", CVV = "7269", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 46, Codigo = "95491", MeioPgtoId = 0, Conta = "517821 739949 0254", NomeResponsavel = "Kennan M. Goff", DataExpiracao = "03 / 2020", CVV = "3534", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 47, Codigo = "31378", MeioPgtoId = 0, Conta = "5551 1543 3914 2157", NomeResponsavel = "Maryam P. Hodges", DataExpiracao = "11 / 2020", CVV = "9006", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 48, Codigo = "19518", MeioPgtoId = 1, Conta = "527288 780986 1297", NomeResponsavel = "Charissa E. Daniel", DataExpiracao = "03 / 2019", CVV = "4560", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 49, Codigo = "23963", MeioPgtoId = 0, Conta = "553 03542 41664 340", NomeResponsavel = "Aaron M. Reyes", DataExpiracao = "12 / 2019", CVV = "6240", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 50, Codigo = "50791", MeioPgtoId = 0, Conta = "520920 888088 9552", NomeResponsavel = "Leo H. Robinson", DataExpiracao = "03 / 2019", CVV = "2764", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 51, Codigo = "71562", MeioPgtoId = 0, Conta = "524 69242 73525 463", NomeResponsavel = "Daria Q. Kline", DataExpiracao = "01 / 2019", CVV = "2799", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 52, Codigo = "26936", MeioPgtoId = 0, Conta = "517884 866417 2043", NomeResponsavel = "Cody R. Reed", DataExpiracao = "11 / 2020", CVV = "6810", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 53, Codigo = "98323", MeioPgtoId = 1, Conta = "557017 1752912962", NomeResponsavel = "Erich R. Mcneil", DataExpiracao = "02 / 2019", CVV = "8670", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 54, Codigo = "85923", MeioPgtoId = 1, Conta = "544444 394990 4556", NomeResponsavel = "Meghan Q. Gibbs", DataExpiracao = "04 / 2020", CVV = "4868", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 55, Codigo = "53589", MeioPgtoId = 0, Conta = "533 07409 00209 330", NomeResponsavel = "Hedley R. Davenport", DataExpiracao = "10 / 2020", CVV = "7567", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 56, Codigo = "72916", MeioPgtoId = 1, Conta = "524590 5689084881", NomeResponsavel = "Guy Z. Luna", DataExpiracao = "11 / 2020", CVV = "7098", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 57, Codigo = "16138", MeioPgtoId = 1, Conta = "524 54059 59019 428", NomeResponsavel = "Stacey J. Duran", DataExpiracao = "02 / 2020", CVV = "7220", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 58, Codigo = "21896", MeioPgtoId = 0, Conta = "5143103204390909", NomeResponsavel = "Pearl I. Bond", DataExpiracao = "11 / 2019", CVV = "2826", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 59, Codigo = "47918", MeioPgtoId = 0, Conta = "5230 9049 1419 9801", NomeResponsavel = "Tyrone S. House", DataExpiracao = "04 / 2019", CVV = "9249", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 60, Codigo = "42167", MeioPgtoId = 0, Conta = "527 38574 38484 588", NomeResponsavel = "Brett B. Patrick", DataExpiracao = "08 / 2019", CVV = "5456", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 61, Codigo = "31054", MeioPgtoId = 0, Conta = "5439772389864988", NomeResponsavel = "Rylee B. Baldwin", DataExpiracao = "01 / 2019", CVV = "4076", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 62, Codigo = "94656", MeioPgtoId = 0, Conta = "5332 9071 9873 9843", NomeResponsavel = "Arthur D. Wilkinson", DataExpiracao = "12 / 2020", CVV = "3836", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 63, Codigo = "62544", MeioPgtoId = 0, Conta = "554789 8630456917", NomeResponsavel = "Naida L. Dixon", DataExpiracao = "01 / 2021", CVV = "1155", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 64, Codigo = "01189", MeioPgtoId = 1, Conta = "512 71824 48466 568", NomeResponsavel = "Libby Y. Bruce", DataExpiracao = "08 / 2020", CVV = "7750", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 65, Codigo = "57250", MeioPgtoId = 1, Conta = "5249 0633 9194 1513", NomeResponsavel = "Dawn B. Gross", DataExpiracao = "08 / 2020", CVV = "1513", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 66, Codigo = "48391", MeioPgtoId = 1, Conta = "552 54458 65908 810", NomeResponsavel = "Graham L. Boyle", DataExpiracao = "02 / 2019", CVV = "9587", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 67, Codigo = "66893", MeioPgtoId = 1, Conta = "5175 5604 0177 3883", NomeResponsavel = "Lacey S. Hansen", DataExpiracao = "09 / 2020", CVV = "9315", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 68, Codigo = "65877", MeioPgtoId = 0, Conta = "5115230127894552", NomeResponsavel = "Nadine A. Cotton", DataExpiracao = "07 / 2020", CVV = "9060", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 69, Codigo = "45619", MeioPgtoId = 1, Conta = "5407421343308132", NomeResponsavel = "Kareem H. Butler", DataExpiracao = "02 / 2020", CVV = "8712", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 70, Codigo = "07973", MeioPgtoId = 1, Conta = "513290 448574 2806", NomeResponsavel = "Faith U. Meyers", DataExpiracao = "01 / 2020", CVV = "5863", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 71, Codigo = "11793", MeioPgtoId = 0, Conta = "525 33089 79208 097", NomeResponsavel = "Darius Q. Briggs", DataExpiracao = "06 / 2019", CVV = "3306", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 72, Codigo = "28152", MeioPgtoId = 1, Conta = "5462654898126366", NomeResponsavel = "Madonna N. Mcneil", DataExpiracao = "09 / 2019", CVV = "3363", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 73, Codigo = "05101", MeioPgtoId = 1, Conta = "5106748295143586", NomeResponsavel = "Samantha O. Erickson", DataExpiracao = "05 / 2020", CVV = "2372", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 74, Codigo = "26719", MeioPgtoId = 1, Conta = "559584 769052 9890", NomeResponsavel = "Roth N. Stevenson", DataExpiracao = "02 / 2020", CVV = "1291", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 75, Codigo = "58655", MeioPgtoId = 0, Conta = "511 62891 05441 157", NomeResponsavel = "Leila R. Russell", DataExpiracao = "06 / 2020", CVV = "1939", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 76, Codigo = "40364", MeioPgtoId = 0, Conta = "5555092119748882", NomeResponsavel = "Ross A. Sherman", DataExpiracao = "03 / 2020", CVV = "9316", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 77, Codigo = "49538", MeioPgtoId = 0, Conta = "5535 7867 4656 7574", NomeResponsavel = "Armand D. Stevenson", DataExpiracao = "05 / 2019", CVV = "7120", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 78, Codigo = "19811", MeioPgtoId = 1, Conta = "539 71965 09294 977", NomeResponsavel = "Malachi O. Mckee", DataExpiracao = "09 / 2020", CVV = "3824", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 79, Codigo = "25799", MeioPgtoId = 0, Conta = "521581 5423973552", NomeResponsavel = "Phillip K. Brewer", DataExpiracao = "03 / 2020", CVV = "4461", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 80, Codigo = "11338", MeioPgtoId = 1, Conta = "5301836056470901", NomeResponsavel = "Moana U. Walsh", DataExpiracao = "06 / 2019", CVV = "4484", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 81, Codigo = "63179", MeioPgtoId = 0, Conta = "524776 437619 9017", NomeResponsavel = "Brandon W. Barker", DataExpiracao = "07 / 2020", CVV = "1794", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 82, Codigo = "84161", MeioPgtoId = 1, Conta = "514772 844749 8832", NomeResponsavel = "Chastity Q. Atkins", DataExpiracao = "09 / 2020", CVV = "1215", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 83, Codigo = "10300", MeioPgtoId = 0, Conta = "5120 4267 1771 1494", NomeResponsavel = "Amy Y. Short", DataExpiracao = "03 / 2019", CVV = "2330", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 84, Codigo = "65163", MeioPgtoId = 1, Conta = "552690 9763358419", NomeResponsavel = "Nadine E. Stuart", DataExpiracao = "07 / 2019", CVV = "1548", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 85, Codigo = "54790", MeioPgtoId = 0, Conta = "510787 385055 0410", NomeResponsavel = "Cameron H. Brooks", DataExpiracao = "07 / 2020", CVV = "3490", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 86, Codigo = "53428", MeioPgtoId = 1, Conta = "5160 2485 0913 6412", NomeResponsavel = "Olivia D. Acosta", DataExpiracao = "05 / 2020", CVV = "6116", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 87, Codigo = "83229", MeioPgtoId = 1, Conta = "5434352236754149", NomeResponsavel = "Sade Z. Kelley", DataExpiracao = "11 / 2020", CVV = "7903", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 88, Codigo = "88593", MeioPgtoId = 1, Conta = "515870 1403919345", NomeResponsavel = "Destiny I. Rollins", DataExpiracao = "02 / 2019", CVV = "7909", NParcelasId = 1 },
                new ApoliceDadosPagamentoDTO { Id = 89, Codigo = "82907", MeioPgtoId = 1, Conta = "522 57932 94670 102", NomeResponsavel = "Callum E. Humphrey", DataExpiracao = "09 / 2020", CVV = "1678", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 90, Codigo = "74654", MeioPgtoId = 1, Conta = "543018 684785 2494", NomeResponsavel = "Dolan M. Whitfield", DataExpiracao = "04 / 2019", CVV = "9931", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 91, Codigo = "46862", MeioPgtoId = 1, Conta = "557 18521 41188 963", NomeResponsavel = "Sylvia V. Tyson", DataExpiracao = "08 / 2020", CVV = "6839", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 92, Codigo = "03313", MeioPgtoId = 0, Conta = "554130 776226 5092", NomeResponsavel = "Cade R. Walls", DataExpiracao = "07 / 2019", CVV = "1352", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 93, Codigo = "65031", MeioPgtoId = 0, Conta = "5267 0990 5018 2046", NomeResponsavel = "Eden O. Humphrey", DataExpiracao = "02 / 2020", CVV = "5636", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 94, Codigo = "74808", MeioPgtoId = 1, Conta = "5416 1732 6101 6317", NomeResponsavel = "Kyle Y. Reed", DataExpiracao = "05 / 2019", CVV = "7670", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 95, Codigo = "40813", MeioPgtoId = 0, Conta = "550 10810 27801 078", NomeResponsavel = "Jared L. Henderson", DataExpiracao = "10 / 2020", CVV = "1374", NParcelasId = 2 },
                new ApoliceDadosPagamentoDTO { Id = 96, Codigo = "19234", MeioPgtoId = 0, Conta = "519891 3931495753", NomeResponsavel = "Lyle R. Schmidt", DataExpiracao = "05 / 2020", CVV = "7070", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 97, Codigo = "94249", MeioPgtoId = 1, Conta = "513 27904 18497 059", NomeResponsavel = "Cameron A. Richardson", DataExpiracao = "04 / 2020", CVV = "1652", NParcelasId = 4 },
                new ApoliceDadosPagamentoDTO { Id = 98, Codigo = "73928", MeioPgtoId = 0, Conta = "510949 048113 6036", NomeResponsavel = "Brennan N. Rosales", DataExpiracao = "01 / 2020", CVV = "7247", NParcelasId = 3 },
                new ApoliceDadosPagamentoDTO { Id = 99, Codigo = "78034", MeioPgtoId = 0, Conta = "5315 7033 7773 4981", NomeResponsavel = "Hedy H. Brooks", DataExpiracao = "01 / 2019", CVV = "3244", NParcelasId = 5 },
                new ApoliceDadosPagamentoDTO { Id = 100, Codigo = "44506", MeioPgtoId = 0, Conta = "558640 446800 3137", NomeResponsavel = "Driscoll H. Bryan", DataExpiracao = "11 / 2020", CVV = "2723", NParcelasId = 1 }
            };

        }
    }
}
