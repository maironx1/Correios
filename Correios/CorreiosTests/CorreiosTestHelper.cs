namespace CorreiosTests
{
    class CorreiosTestHelper
    {
        public static string[] Trechos { get; set; } =
            { "LS SF 1",
                "SF LS 2",
                "LS LV 1",
                "LV LS 1",
                "SF LV 2",
                "LV SF 2",
                "LS RC 1",
                "RC LS 2",
                "SF WS 1",
                "WS SF 2",
                "LV BC 1",
                "BC LV 1"
            };
        public static string[] Encomendas { get; set; } =
            {
                "SF WS",
                "LS BC",
                "WS BC"
            };
        public static string[] Resultado { get; set; } =
            {
                "SF WS 1",
                "LS LV BC 2",
                "WS SF LV BC 5",
            };

    }
}
