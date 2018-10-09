
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace siwp_app.Models
{
    public class ScreenSeed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new SiwpContext(
                serviceProvider.GetRequiredService<DbContextOptions<SiwpContext>>()))
            {
                // Look for any Screens.
                if (context.Screens.Any())
                {
                    return;   // DB has been seeded
                }

                context.Screens.AddRange(
        
        new Screen           
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 2,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "H2H CROSSOVER"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "H2H OUTLAW"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "H2H HODTH"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "H2H BACK"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "ROSS COLEMAN"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SHAKE & BAKE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "WARRIORS AND ROEDO"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TRENT HOLT 5K"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SHAKE & BAKE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SURVIVOR FITNESS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SUMMER SOLSTICE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "MARTIN SOCCER"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "WINTERBURN"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "BRAXTON'S JOURNEY"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "BRADFORD'S LAWNCARE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RELIANCE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "JOHN JONES"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP FLAG"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "WRANGLER"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TBF"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SUNSET"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "O BABY"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE MAMA TRIED"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "MMC BASEBALL"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "BANK OF FRANK"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "AMBERLY SNYDER ARROWS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "(CP) CHAD PRATHER MERICA"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "LAZER FORCE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TBF MADE NEW"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "CHAD PRATHER "
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP WITHIN"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "NHC"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "AUSTERMILLER"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP HARVEY"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "NATIONAL GUARD"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP GLORY HOODIE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "MMC SOFTBALL"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "COY LUTZ"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP MERICA"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "RWP CIRCLE UP"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "44WARD"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TTU"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "JUST 4 KIDS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SOUTHSIDE ELEMENTARY"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "CHRISTIANA BAND"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE ANGELS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 MIDDLE",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "FAST PACE "
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "H2H STUFF"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TIN ROOF"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "TRI STAR"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE JD"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE BARN HAIR"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S3 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE HALLOWEEN"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S1 TOP",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "SOUTHSIDE "
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE ARROW & CACTUS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 BOTTOM",
        Quanity = 1,
        ScreenLocation= "SCREEN ROOM",
        ScreenName = "OE VEGAS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 MIDDLE",
        Quanity = 1,
        ScreenLocation= "WAREHOUSE",
        ScreenName = "OUTDOOR POWERSPORTS"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 MIDDLE",
        Quanity = 1,
        ScreenLocation= "WAREHOUSE",
        ScreenName = "OLD RELIANCE"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 TOP",
        Quanity = 1,
        ScreenLocation= "WAREHOUSE",
        ScreenName = "OE NATION"
    },
    new Screen
    {
        MeshCount = "",
        Notes= "",
        Orientation= "S2 MIDDLE",
        Quanity = 1,
        ScreenLocation= "WAREHOUSE",
        ScreenName = "KANYE TWITTY"
    }


                );
                context.SaveChanges();
            }
        }
        
    }
}