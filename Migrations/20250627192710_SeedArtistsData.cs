using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RockProjectBackend.Migrations
{
    /// <inheritdoc />
    public partial class SeedArtistsData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artistas",
                columns: new[] { "Id", "AlbumDestacado", "CancionDestacada", "Imagen", "Nombre", "Resena", "Subgenero" },
                values: new object[,]
                {
                    { 1, "Elvis Presley (1956)", "Hound Dog", "https://upload.wikimedia.org/wikipedia/commons/9/99/Elvis_Presley_promoting_Jailhouse_Rock.jpg", "Elvis Presley", "Considerado el 'Rey del Rock and Roll', su carisma y su fusión de country con rhythm and blues lo convirtieron en un ícono cultural que cambió la música para siempre.", "Rockabilly / Rock and Roll" },
                    { 2, "Chuck Berry Is on Top (1959)", "Johnny B. Goode", "https://upload.wikimedia.org/wikipedia/commons/6/63/Chuck_Berry_in_1957.jpg", "Chuck Berry", "Uno de los padres fundadores del rock, definió su sonido con su distintiva guitarra y letras que capturaban el espíritu de la juventud estadounidense.", "Rock and Roll" },
                    { 3, "Here's Little Richard (1957)", "Tutti Frutti", "https://upload.wikimedia.org/wikipedia/commons/5/56/Little_Richard_1965.jpg", "Little Richard", "Con su energía explosiva, su piano frenético y su voz inconfundible, fue una fuerza pionera que inyectó extravagancia y dinamismo al rock and roll.", "Rock and Roll" },
                    { 4, "The 'Chirping' Crickets (1957)", "Peggy Sue", "https://upload.wikimedia.org/wikipedia/commons/c/cd/Buddy_Holly_in_1958.jpg", "Buddy Holly", "Un innovador compositor y guitarrista cuya carrera, aunque breve, influyó profundamente en la estructura de la música pop y el formato de las bandas de rock.", "Rockabilly" },
                    { 5, "Sgt. Pepper's Lonely Hearts Club Band (1967)", "A Day in the Life", "https://upload.wikimedia.org/wikipedia/commons/d/df/The_Fabs.JPG", "The Beatles", "Originarios de Liverpool, los 'Fab Four' revolucionaron la música popular con su innovadora composición, armonías vocales y experimentación en el estudio.", "Rock Psicodélico / Pop Rock" },
                    { 6, "Exile on Main St. (1972)", "(I Can't Get No) Satisfaction", "https://upload.wikimedia.org/wikipedia/commons/7/78/The_Rolling_Stones_in_1965.jpg", "The Rolling Stones", "La encarnación de la rebeldía del rock, con un sonido crudo basado en el blues y una actitud que los ha mantenido como una de las bandas más grandes durante décadas.", "Blues Rock / Rock and Roll" },
                    { 7, "Who's Next (1971)", "Baba O'Riley", "https://upload.wikimedia.org/wikipedia/commons/f/f7/The_Who_1975.jpg", "The Who", "Conocidos por sus óperas rock y sus explosivas actuaciones en vivo, The Who empujó los límites del sonido y la narrativa en la música rock.", "Hard Rock / Rock" },
                    { 8, "Led Zeppelin IV (1971)", "Stairway to Heaven", "https://upload.wikimedia.org/wikipedia/commons/4/4f/Led_Zeppelin_-_1975.jpg", "Led Zeppelin", "Pioneros del hard rock y el heavy metal, esta banda británica es célebre por sus poderosos riffs de guitarra y su épica musicalidad.", "Hard Rock / Folk Rock" },
                    { 9, "The Dark Side of the Moon (1973)", "Money", "https://upload.wikimedia.org/wikipedia/en/d/d6/Pink_Floyd_-_all_members.jpg", "Pink Floyd", "Maestros del rock progresivo y psicodélico, son conocidos por sus álbumes conceptuales, letras filosóficas y espectáculos en vivo elaborados.", "Rock Progresivo / Psicodélico" },
                    { 10, "Are You Experienced (1967)", "Purple Haze", "https://upload.wikimedia.org/wikipedia/commons/a/ae/Jimi_Hendrix_1967.png", "Jimi Hendrix", "Considerado el guitarrista más influyente de la historia, redefinió las posibilidades del instrumento con su técnica innovadora y su uso de la distorsión y el feedback.", "Rock Psicodélico / Hard Rock" },
                    { 11, "A Night at the Opera (1975)", "Bohemian Rhapsody", "https://upload.wikimedia.org/wikipedia/commons/3/33/Queen_in_1977.jpg", "Queen", "Liderados por el incomparable Freddie Mercury, fusionaron el glam, el hard rock y la ópera para crear un sonido grandilocuente y único.", "Glam Rock / Hard Rock" },
                    { 12, "The Rise and Fall of Ziggy Stardust...", "Heroes", "https://upload.wikimedia.org/wikipedia/commons/e/e8/David-Bowie_Chicago_2002-08-08_cropped.jpg", "David Bowie", "Un camaleón musical y cultural, Bowie constantemente reinventó su imagen y sonido, explorando géneros desde el glam hasta la electrónica.", "Glam Rock / Art Rock" },
                    { 13, "Highway 61 Revisited (1965)", "Like a Rolling Stone", "https://upload.wikimedia.org/wikipedia/commons/0/02/Bob_Dylan_-_Azkena_Rock_Festival_2010_1.jpg", "Bob Dylan", "La voz de una generación, sus poéticas y socialmente conscientes letras transformaron la música folk y la elevaron a una forma de arte literario.", "Folk Rock" },
                    { 14, "The Doors (1967)", "Light My Fire", "https://upload.wikimedia.org/wikipedia/commons/7/79/The_Doors_1968.jpg", "The Doors", "Con la poesía oscura de Jim Morrison y el sonido hipnótico de sus teclados, The Doors exploró los rincones más oscuros de la psique humana.", "Rock Psicodélico" },
                    { 15, "Cosmo's Factory (1970)", "Fortunate Son", "https://upload.wikimedia.org/wikipedia/commons/3/3e/Creedence_Clearwater_Revival_1968.jpg", "Creedence Clearwater Revival", "Liderados por John Fogerty, crearon un sonido distintivo de rock sureño con éxitos concisos y potentes que se convirtieron en himnos.", "Swamp Rock / Roots Rock" },
                    { 16, "Paranoid (1970)", "Paranoid", "https://upload.wikimedia.org/wikipedia/commons/8/87/Black_Sabbath_1970.jpg", "Black Sabbath", "Considerados los creadores del heavy metal, sus riffs oscuros y pesados, cortesía de Tony Iommi, sentaron las bases para todo un género.", "Heavy Metal / Hard Rock" },
                    { 17, "Back in Black (1980)", "Back in Black", "https://upload.wikimedia.org/wikipedia/commons/9/91/ACDC_in_2001.jpg", "AC/DC", "La personificación del rock and roll directo y sin concesiones. Su música se basa en riffs de guitarra simples, potentes y memorables.", "Hard Rock" },
                    { 18, "Hotel California (1976)", "Hotel California", "https://upload.wikimedia.org/wikipedia/commons/b/b5/Eagles_band_on_tour.jpg", "Eagles", "Maestros de las armonías vocales y del sonido californiano, mezclaron el country con el soft rock para crear algunas de las canciones más vendidas de la historia.", "Soft Rock / Country Rock" },
                    { 19, "Rumours (1977)", "Go Your Own Way", "https://upload.wikimedia.org/wikipedia/commons/f/fe/Fleetwood_Mac_Billboard_1977.jpg", "Fleetwood Mac", "Con una mezcla única de talento británico y estadounidense, crearon pop-rock sofisticado, marcado por sus complejas relaciones internas.", "Soft Rock / Pop Rock" },
                    { 20, "Ramones (1976)", "Blitzkrieg Bop", "https://upload.wikimedia.org/wikipedia/commons/6/6b/Ramones_in_Tivoli_Stockholm_1977.jpg", "Ramones", "Pioneros del punk, despojaron el rock a su esencia más básica: tres acordes, velocidad y una energía cruda y contagiosa.", "Punk Rock" },
                    { 21, "Never Mind the Bollocks...", "Anarchy in the U.K.", "https://upload.wikimedia.org/wikipedia/commons/f/ff/Sex_Pistols-publicity-shot-1977.jpg", "Sex Pistols", "La banda que encarnó la furia y el nihilismo del punk británico. Su breve y caótica existencia dejó una marca indeleble en la música y la cultura.", "Punk Rock" },
                    { 22, "London Calling (1979)", "London Calling", "https://upload.wikimedia.org/wikipedia/commons/0/07/The_Clash_at_the_Lochem_Festival_1982.jpg", "The Clash", "Conocidos como 'la única banda que importa', fusionaron el punk con reggae, ska y rockabilly, abordando temas políticos y sociales.", "Punk Rock / New Wave" },
                    { 23, "The Joshua Tree (1987)", "With or Without You", "https://upload.wikimedia.org/wikipedia/commons/b/b5/U2_in_2017.jpg", "U2", "Desde sus raíces post-punk, se convirtieron en una de las bandas más grandes del mundo, con el sonido de guitarra de The Edge y la voz apasionada de Bono.", "Alternative Rock / Post-Punk" },
                    { 24, "Appetite for Destruction (1987)", "Sweet Child o' Mine", "https://upload.wikimedia.org/wikipedia/commons/3/3b/Guns_N%27_Roses_at_The_O2_Arena_-_2012_%282%29.jpg", "Guns N' Roses", "Irrumpieron en la escena de los 80 con una peligrosa mezcla de hard rock, punk y blues, personificando el exceso del rock de estadio.", "Hard Rock" },
                    { 25, "Born to Run (1975)", "Born to Run", "https://upload.wikimedia.org/wikipedia/commons/f/f4/Bruce_Springsteen_-_Roskilde_Festival_2012.jpg", "Bruce Springsteen", "Conocido como 'The Boss', sus canciones son crónicas de la vida de la clase trabajadora estadounidense, llenas de pasión y energía rockera.", "Heartland Rock" },
                    { 26, "Nevermind (1991)", "Smells Like Teen Spirit", "https://upload.wikimedia.org/wikipedia/commons/1/19/Nirvana_around_1992.jpg", "Nirvana", "Lideraron la revolución del grunge, cambiando el panorama musical de los 90 con su sonido que alternaba entre la apatía y la furia.", "Grunge / Alternative Rock" },
                    { 27, "Ten (1991)", "Alive", "https://upload.wikimedia.org/wikipedia/commons/5/5e/Pearl_Jam_in_2009.jpg", "Pearl Jam", "Una de las bandas más influyentes de la escena de Seattle, conocidos por la intensa voz de Eddie Vedder y su postura anti-corporativa.", "Grunge / Alternative Rock" },
                    { 28, "Automatic for the People (1992)", "Losing My Religion", "https://upload.wikimedia.org/wikipedia/commons/b/b0/R.E.M._Press_Conference_in_Mexico_City.jpg", "R.E.M.", "Pioneros del rock alternativo, su sonido jangle-pop y las enigmáticas letras de Michael Stipe los llevaron del underground a la fama mundial.", "Alternative Rock" },
                    { 29, "Californication (1999)", "Under the Bridge", "https://upload.wikimedia.org/wikipedia/commons/8/89/Red_Hot_Chili_Peppers_2012-08-26_Rock_en_Seine_01.jpg", "Red Hot Chili Peppers", "Fusionaron funk, punk y rock psicodélico para crear un sonido enérgico y distintivo, impulsado por la icónica línea de bajo de Flea.", "Funk Rock / Alternative Rock" },
                    { 30, "Master of Puppets (1986)", "Master of Puppets", "https://upload.wikimedia.org/wikipedia/commons/b/b7/Metallica_at_The_O2_Arena_London_2008.jpg", "Metallica", "Una de las bandas de heavy metal más exitosas de la historia, definieron el thrash metal con su velocidad, agresividad y complejidad musical.", "Thrash Metal" },
                    { 31, "Synchronicity (1983)", "Every Breath You Take", "https://upload.wikimedia.org/wikipedia/commons/a/a4/The_Police_in_concert_in_1981_-_2.jpg", "The Police", "Este trío británico mezcló rock con influencias de reggae y jazz, creando un sonido sofisticado y minimalista que dominó las radios de los 80.", "New Wave / Post-Punk" },
                    { 32, "Brothers in Arms (1985)", "Sultans of Swing", "https://upload.wikimedia.org/wikipedia/commons/4/4b/Dire_Straits_-_Hammersmith_Odeon_1979_03.jpg", "Dire Straits", "Liderados por la inconfundible guitarra y voz de Mark Knopfler, su sonido limpio y melódico fue un contrapunto al punk y la new wave.", "Blues Rock / Roots Rock" },
                    { 33, "OK Computer (1997)", "Paranoid Android", "https://upload.wikimedia.org/wikipedia/commons/2/22/Radiohead_Coachella_2017.jpg", "Radiohead", "Constantemente empujando los límites de la música rock, son conocidos por su experimentación sónica y sus temas de alienación moderna.", "Alternative Rock / Art Rock" },
                    { 34, "(What's the Story) Morning Glory? (1995)", "Wonderwall", "https://upload.wikimedia.org/wikipedia/commons/f/fb/Oasis_2008.jpg", "Oasis", "La banda insignia del movimiento Britpop de los 90, con himnos de estadio y la volátil relación entre los hermanos Gallagher en su núcleo.", "Britpop" },
                    { 35, "The Queen Is Dead (1986)", "There Is a Light That Never Goes Out", "https://upload.wikimedia.org/wikipedia/en/2/29/The_Smiths_promo_photo.jpg", "The Smiths", "Definieron el sonido del rock indie británico de los 80 con las guitarras de Johnny Marr y las melancólicas letras de Morrissey.", "Jangle Pop / Indie Rock" },
                    { 36, "Disintegration (1989)", "Just Like Heaven", "https://upload.wikimedia.org/wikipedia/commons/8/87/The_Cure_in_2016.jpg", "The Cure", "Liderados por Robert Smith, transitaron del post-punk a un pop melancólico y atmosférico, convirtiéndose en íconos del rock gótico.", "Gothic Rock / New Wave" },
                    { 37, "Superunknown (1994)", "Black Hole Sun", "https://upload.wikimedia.org/wikipedia/commons/e/e5/Soundgarden_Rock_am_Ring_2012.jpg", "Soundgarden", "Una de las bandas pilares del grunge, destacaron por su complejidad técnica y la increíble potencia vocal de Chris Cornell.", "Grunge / Hard Rock" },
                    { 38, "The Colour and the Shape (1997)", "Everlong", "https://upload.wikimedia.org/wikipedia/commons/d/d4/Foo_Fighters_at_Lollapalooza_Chile_2012.jpg", "Foo Fighters", "Nacidos de las cenizas de Nirvana, la banda de Dave Grohl se convirtió en un pilar del rock de estadio con himnos enérgicos y melódicos.", "Alternative Rock / Post-Grunge" },
                    { 39, "Dookie (1994)", "Basket Case", "https://upload.wikimedia.org/wikipedia/commons/8/89/Green_Day_-_d.jpg", "Green Day", "Llevaron el pop-punk al mainstream con melodías pegadizas y una energía juvenil que revitalizó el género en los años 90.", "Pop Punk / Punk Rock" },
                    { 40, "Is This It (2001)", "Last Nite", "https://upload.wikimedia.org/wikipedia/commons/7/7b/The_Strokes_2006.jpg", "The Strokes", "Lideraron el resurgimiento del garage rock a principios de los 2000 con un sonido cool, minimalista y lleno de guitarras angulares.", "Indie Rock / Garage Rock Revival" },
                    { 41, "Elephant (2003)", "Seven Nation Army", "https://upload.wikimedia.org/wikipedia/commons/d/d7/The_White_Stripes_live_at_the_O2_Wireless_Festival_2007.jpg", "The White Stripes", "Este dúo de Detroit revitalizó el blues y el garage rock con un enfoque minimalista pero potente: solo guitarra y batería.", "Garage Rock / Blues Rock" },
                    { 42, "Whatever People Say I Am...", "I Bet You Look Good on the Dancefloor", "https://upload.wikimedia.org/wikipedia/commons/0/08/Arctic_Monkeys_at_The_O2_Arena_%282013%29.jpg", "Arctic Monkeys", "Fueron una de las primeras bandas en saltar a la fama gracias a internet, con letras ingeniosas sobre la vida nocturna juvenil y riffs de guitarra frenéticos.", "Indie Rock / Post-Punk Revival" },
                    { 43, "Only by the Night (2008)", "Sex on Fire", "https://upload.wikimedia.org/wikipedia/commons/d/d3/Kings_of_Leon_at_the_O2_Arena%2C_2013_%283%29.jpg", "Kings of Leon", "Evolucionaron de un rock sureño y crudo a un sonido de rock de estadio pulido que les otorgó fama mundial a finales de los 2000.", "Alternative Rock" },
                    { 44, "Hybrid Theory (2000)", "In the End", "https://upload.wikimedia.org/wikipedia/commons/9/9f/Linkin_park_2010.jpg", "Linkin Park", "Definieron el sonido nu-metal de los 2000 al fusionar rock, hip-hop y electrónica, con letras que conectaron con una generación de jóvenes.", "Nu Metal / Alternative Rock" },
                    { 45, "Absolution (2003)", "Hysteria", "https://upload.wikimedia.org/wikipedia/commons/9/91/Muse_in_2010.jpg", "Muse", "Este trío británico es conocido por su sonido grandilocuente, que mezcla rock alternativo con ópera, electrónica y temas conspiranoicos.", "Alternative Rock / Space Rock" },
                    { 46, "A Rush of Blood to the Head (2002)", "Clocks", "https://upload.wikimedia.org/wikipedia/commons/7/73/Coldplay_live_at_the_Rock_im_Park_2011.jpg", "Coldplay", "Desde sus inicios en el rock alternativo melódico, se han convertido en una de las bandas de pop-rock más grandes del planeta.", "Alternative Rock / Pop Rock" },
                    { 47, "Full Moon Fever (1989)", "Free Fallin'", "https://upload.wikimedia.org/wikipedia/commons/b/b5/Tom_Petty_and_the_Heartbreakers_in_2012.jpg", "Tom Petty", "Un maestro de la composición de canciones, Tom Petty creó un rock clásico y atemporal, con melodías que se sienten instantáneamente familiares.", "Heartland Rock" },
                    { 48, "Pearl (1971)", "Me and Bobby McGee", "https://upload.wikimedia.org/wikipedia/commons/9/98/Janis_Joplin_in_1969_%28cropped%29.jpg", "Janis Joplin", "Con una voz cruda, poderosa y llena de emoción, Janis Joplin fue una de las cantantes de rock y blues más icónicas de su era.", "Blues Rock" },
                    { 49, "(Pronounced 'Lĕh-'nérd 'Skin-'nérd')", "Sweet Home Alabama", "https://upload.wikimedia.org/wikipedia/commons/b/b3/Lynyrd_Skynyrd_-_Cobo_Hall.jpg", "Lynyrd Skynyrd", "La banda por excelencia del rock sureño, conocidos por su triple ataque de guitarras y por himnos que definieron el género.", "Southern Rock" },
                    { 50, "Parallel Lines (1978)", "Heart of Glass", "https://upload.wikimedia.org/wikipedia/commons/a/a6/Blondie_-_1977.jpg", "Blondie", "Surgidos de la escena punk de Nueva York, Blondie y la icónica Debbie Harry fusionaron punk, disco y pop para dominar las listas de éxitos.", "New Wave / Punk Rock" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Artistas",
                keyColumn: "Id",
                keyValue: 50);
        }
    }
}
