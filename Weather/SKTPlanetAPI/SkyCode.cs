using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Weather.SKTPlanetAPI
{

    public class SkyCode
    {

        public static String GetSkyIcon(Int32 hour,String Code)
        {
            if(hour >= 20 || hour <= 4)
            {
                Sky_Icon_Night Icon = (Sky_Icon_Night)Enum.Parse(typeof(Sky_Icon_Night), Code);
                return "_" + ((int)Icon).ToString();
            }
            else
            {
                Sky_Icon Icon = (Sky_Icon)Enum.Parse(typeof(Sky_Icon), Code);
                return "_" + ((int)Icon).ToString();
            }
        }

        enum Sky_Icon
        {
            //간편
            SKY_D01 = 1,
            SKY_D02 = 2,
            SKY_D03 = 3,
            SKY_D04 = 18,
            SKY_D05 = 20,
            SKY_D06 = 33,
            SKY_D07 = 4,
            
            SKY_M01 = 1,
            SKY_M02 = 2,
            SKY_M03 = 3,
            SKY_M04 = 18,
            SKY_M05 = 20,
            SKY_M06 = 33,
            SKY_M07 = 4,
            //분별
            SKY_A00 = 38,
            SKY_A01 = 1,
            SKY_A02 = 2,
            SKY_A03 = 3,
            SKY_A04 = 12,
            SKY_A05 = 13,
            SKY_A06 = 14,
            SKY_A07 = 18,
            SKY_A08 = 21,
            SKY_A09 = 32,
            SKY_A10 = 4,
            SKY_A11 = 29,
            SKY_A12 = 26,
            SKY_A13 = 27,
            SKY_A14 = 28,
            //시간별
            SKY_O00 = 38,
            SKY_O01 = 1,
            SKY_O02 = 2,
            SKY_O03 = 3,
            SKY_O04 = 12,
            SKY_O05 = 13,
            SKY_O06 = 14,
            SKY_O07 = 18,
            SKY_O08 = 21,
            SKY_O09 = 32,
            SKY_O10 = 4,
            SKY_O11 = 29,
            SKY_O12 = 26,
            SKY_O13 = 27,
            SKY_O14 = 28,
            //초단기 예보
            SKY_V00 = 38,
            SKY_V01 = 1,
            SKY_V02 = 2,
            SKY_V03 = 3,
            SKY_V04 = 12,
            SKY_V05 = 13,
            SKY_V06 = 14,
            SKY_V07 = 18,
            SKY_V08 = 21,
            SKY_V09 = 32,
            SKY_V10 = 4,
            SKY_V11 = 29,
            SKY_V12 = 26,
            SKY_V13 = 27,
            SKY_V14 = 28,
            //단기예보
            SKY_S00 = 38,
            SKY_S01 = 1,
            SKY_S02 = 2,
            SKY_S03 = 3,
            SKY_S04 = 12,
            SKY_S05 = 13,
            SKY_S06 = 14,
            SKY_S07 = 18,
            SKY_S08 = 21,
            SKY_S09 = 32,
            SKY_S10 = 4,
            SKY_S11 = 29,
            SKY_S12 = 26,
            SKY_S13 = 27,
            SKY_S14 = 28,
            //중기예보
            SKY_W00 = 38,
            SKY_W01 = 1,
            SKY_W02 = 2,
            SKY_W03 = 3,
            SKY_W04 = 18,
            SKY_W07 = 21,
            SKY_W09 = 12,
            SKY_W10 = 21,
            SKY_W11 = 4,
            SKY_W12 = 13,
            SKY_W13 = 32,
            //어제 날씨
            SKY_Y00 = 38,
            SKY_Y01 = 1,
            SKY_Y02 = 2,
            SKY_Y03 = 3,
            SKY_Y04 = 18,
            SKY_Y05 = 21,
            SKY_Y06 = 32,
            SKY_Y07 = 4
        }

        enum Sky_Icon_Night
        {
            //간편
            SKY_D01 = 8,
            SKY_D02 = 9,
            SKY_D03 = 10,
            SKY_D04 = 18,
            SKY_D05 = 20,
            SKY_D06 = 33,
            SKY_D07 = 4,

            SKY_M01 = 8,
            SKY_M02 = 9,
            SKY_M03 = 10,
            SKY_M04 = 18,
            SKY_M05 = 20,
            SKY_M06 = 33,
            SKY_M07 = 4,
            //분별
            SKY_A00 = 38,
            SKY_A01 = 8,
            SKY_A02 = 9,
            SKY_A03 = 10,
            SKY_A04 = 40,
            SKY_A05 = 41,
            SKY_A06 = 42,
            SKY_A07 = 18,
            SKY_A08 = 21,
            SKY_A09 = 32,
            SKY_A10 = 4,
            SKY_A11 = 29,
            SKY_A12 = 26,
            SKY_A13 = 27,
            SKY_A14 = 28,
            //시간별
            SKY_O00 = 38,
            SKY_O01 = 8,
            SKY_O02 = 9,
            SKY_O03 = 10,
            SKY_O04 = 40,
            SKY_O05 = 41,
            SKY_O06 = 42,
            SKY_O07 = 18,
            SKY_O08 = 21,
            SKY_O09 = 32,
            SKY_O10 = 4,
            SKY_O11 = 29,
            SKY_O12 = 26,
            SKY_O13 = 27,
            SKY_O14 = 28,
            //초단기 예보 
            SKY_V00 = 38,
            SKY_V01 = 8,
            SKY_V02 = 9,
            SKY_V03 = 10,
            SKY_V04 = 40,
            SKY_V05 = 41,
            SKY_V06 = 42,
            SKY_V07 = 18,
            SKY_V08 = 21,
            SKY_V09 = 32,
            SKY_V10 = 4,
            SKY_V11 = 29,
            SKY_V12 = 26,
            SKY_V13 = 27,
            SKY_V14 = 28,
            //단기예보
            SKY_S00 = 38,
            SKY_S01 = 8,
            SKY_S02 = 9,
            SKY_S03 = 10,
            SKY_S04 = 40,
            SKY_S05 = 41,
            SKY_S06 = 42,
            SKY_S07 = 18,
            SKY_S08 = 21,
            SKY_S09 = 32,
            SKY_S10 = 4,
            SKY_S11 = 29,
            SKY_S12 = 26,
            SKY_S13 = 27,
            SKY_S14 = 28,
            //중기예보
            SKY_W00 = 38,
            SKY_W01 = 8,
            SKY_W02 = 9,
            SKY_W03 = 10,
            SKY_W04 = 18,
            SKY_W07 = 21,
            SKY_W09 = 40,
            SKY_W10 = 21,
            SKY_W11 = 4,
            SKY_W12 = 41,
            SKY_W13 = 32,
            //어제 날씨
            SKY_Y00 = 38,
            SKY_Y01 = 8,
            SKY_Y02 = 9,
            SKY_Y03 = 10,
            SKY_Y04 = 18,
            SKY_Y05 = 21,
            SKY_Y06 = 32,
            SKY_Y07 = 4
        }

    }
}
