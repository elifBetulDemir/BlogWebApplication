﻿// <auto-generated />
using System;
using Blog.Infrastructure.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Blog.Infrastructure.Migrations
{
    [DbContext(typeof(BlogContext))]
    partial class BlogContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Blog.Entities.Concrete.About", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Details2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MapLocation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Abouts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Details = "Blog (Türkçe: ağ günlüğü, günce) veya Weblog (Türkçe: Ağ kütüğü) teknik bilgi gerektirmeden, kendi istedikleri şeyleri, kendi istedikleri şekilde yazan insanların oluşturabildikleri, günlüğe benzeyen web siteleridir. Genellikle güncelden eskiye doğru sıralanmış yazı ve yorumların yayınlandığı, web tabanlı bir yayını belirtir. Çoğunlukla her gönderinin sonunda yazarın adı ve gönderi zamanı belirtilir. Yayıncının seçimine göre okuyucular yazılara yorum yapılabilir. Yorumlar, blog kültürünün çok önemli bir dinamiğidir; bu sayede yazar ve okuyucular arasında iletişim sağlanır. Bunun dışında, geri izleme (trackback) mekanizmasıyla, belirli bir yazı hakkında yazılan diğer yazıların belirlenebilmesi de mümkündür.[1]\r\n\r\nGönderiler genellikle ters kronolojik sırada görüntülenir, böylece en son gönderi web sayfasının en üstünde ilk olarak görünür. 2009 yılına kadar, bloglar genellikle tek bir kişinin, ara sıra küçük bir grubun çalışmasıydı ve genellikle tek bir konuyu kapsıyordu. 2010'larda, birden çok yazarın yazılarını içeren ve bazen profesyonelce düzenlenen \"çok yazarlı bloglar\" (MAB'ler) ortaya çıktı. Gazetelerden, diğer medya kuruluşlarından, üniversitelerden, düşünce kuruluşlarından, savunuculuk gruplarından ve benzer kurumlardan gelen MAB'ler, artan miktarda blog trafiğinden sorumludur. Twitter ve diğer \"mikroblog\" sistemlerinin yükselişi, MAB'lerin ve tek yazarlı blogların haber medyasına entegre edilmesine yardımcı olur. 2010 yıllarından sonra özellikle mobil blog'lar popüler oldu.[2] Sosyal medya ve sosyal ağ'ların yaygınlaşması ile bloglar bunlarla artık gevşek bir şekilde kullanılmaktadır.\r\n\r\nİlk bloglar elle yazılıp güncellenirken, bugün bu iş için özel yazılmış yazılımlar kullanılmaktadır. Bu yazılımlardan bazıları bir blog servisi sağlayıcı sitenin alt alan adları olarak yaratılabilen, bazıları ise kullanıcının kendi sunucusuna kurup çalıştırması gereken Blogger, Blogcu.com, WordPress, SpinMedia, joomla, Drupal gibi yazılımlardır.[3]\r\n\r\nPek çok blog, felsefe, din ve sanattan bilim, siyaset ve spora kadar belirli bir konular hakkında yorumlar sağlar. Diğerleri, daha kişisel çevrimiçi günlükler veya belirli bir kişi veya şirketin çevrimiçi marka reklamı işlevi görür. Tipik bir blog, metni, dijital görüntüleri ve diğer bloglara, web sayfalarına ve konusuyla ilgili diğer medyaya bağlantıları birleştirir. Bazıları kişisel (kişisel blog), haber (haber blogu), bilim (bilim blogu), sanat (sanat blogu), moda (moda blogu), felsefe (felsefe blogu), işletme (işletme blogu), fitness (fitness blogu), teknoloji (teknoloji blogu), kitap (kitap blogu), tasarım (tasarım blogu), yemek (yemek blogu), savaş (savaş blogu), teknoloji (teknoloji blogu), siyaset (siyasi blog), ekonomi (ekonomi blogu), hukuk (hukuk blogu), kurumsal (kurumsal blog), feminist (feminist blog), fotoğraflar (fotoblog), videolar (video blogları veya \"vlog'lar\"), müzik (MP3 blogu) ve ses (podcast'ler) konularına odaklansa da, çoğu blog esas olarak metinseldir.[4] Eğitimde, bloglar öğretim kaynakları olarak kullanılabilir; bunlara edublog'lar denir. Edebi blog'lar edebiyatla ilgili bloglardır. Mikroblog, çok kısa gönderiler içeren başka bir blog türüdür. 2022'ye ait bir tahmin, 1,9 milyardan fazla web sitesinden 600 milyondan fazla genel blog olduğunu öne sürdü. Blog oluşturanlara blogcu veya bloger denir. Bunlar çoğunlukla kamusal figür, internet ünlüsü ve diğer sosyal etki'si olan kişilerdir.\r\n\r\nİngilizcedeki \"web\" ve \"log\" kelimelerinin birleşmesinden oluşan weblog kavramının zamanla yaygınlaşmış adıdır.",
                            Status = true
                        });
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Blog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("ThumbnailImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("WriterId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("WriterId");

                    b.ToTable("Blogs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 4,
                            Content = "Lorem ipsum dolor, sit amet consectetur adipisicing elit. Architecto, rerum aliquid? Quam culpa quis inventore recusandae itaque. Quo quas tempora, voluptatibus ab, sunt quis ex quasi fugiat iusto modi explicabo quos rerum consequatur quibusdam fuga laborum iure nam architecto. Placeat qui hic porro suscipit voluptate. Placeat aliquid animi delectus perspiciatis quidem, quo illum nihil obcaecati quisquam, modi, eius unde impedit deleniti sunt eligendi voluptates reprehenderit. Nihil incidunt dolor blanditiis sequi illum, neque molestias quidem laborum dolore ea ipsam at culpa inventore facilis aperiam impedit quo nostrum atque architecto accusamus. Optio praesentium impedit eveniet deleniti atque amet aperiam ab, recusandae quaerat nihil culpa magnam eligendi sapiente ea fugit, accusantium temporibus voluptates dolorum sit aut est. Dolore dolores, consequuntur minus ipsa, eos exercitationem similique quibusdam quos inventore earum maxime molestiae, id ut omnis blanditiis alias sunt totam ad ex consequatur assumenda nihil excepturi dolorum? Molestias at, blanditiis magni libero neque recusandae suscipit voluptatem quibusdam delectus impedit earum illo reprehenderit eligendi quasi labore laudantium iure nam similique quis eum velit. Soluta unde odio explicabo est vel. Quo placeat culpa accusantium similique voluptas aliquam libero nisi saepe vero, iusto totam tenetur pariatur facere commodi, necessitatibus explicabo sapiente fugit hic quisquam modi! Nisi, impedit voluptatibus.",
                            CreateDate = new DateTime(2023, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/5.jpg",
                            Status = true,
                            Title = "İphone 15 Tanıtıldı",
                            WriterId = 1
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 3,
                            Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Inventore, iusto reprehenderit quisquam officiis quae illo ab facere veniam, commodi consequatur corrupti aut a suscipit, nam omnis? Dolor, totam! Esse, eveniet expedita in amet necessitatibus dignissimos, asperiores optio adipisci sapiente obcaecati nam? Enim numquam soluta voluptas, ducimus ab nobis consequatur. Cumque eaque expedita voluptates minima, nostrum laborum itaque obcaecati delectus aliquam officiis illo, repudiandae alias sapiente. Ullam culpa libero perferendis id praesentium nemo autem odit illum totam! Totam quae natus aliquid sunt? Illo, at sed? Ab, id? Ut culpa eaque, in deserunt dicta corporis animi numquam repudiandae porro libero totam amet tempore non ducimus odio hic fugit! Nobis consectetur quibusdam ullam velit sapiente praesentium aspernatur voluptates omnis voluptas delectus nam quisquam magni deserunt, cumque impedit, totam quae atque optio officia esse facilis! Fuga, veritatis obcaecati. Omnis, nulla natus! Ipsam, blanditiis autem excepturi, ullam ducimus ut eligendi officiis aperiam ipsum numquam laborum sapiente doloremque consequatur placeat voluptatum quisquam at saepe dolores iure maiores. Dignissimos eos atque eligendi impedit itaque eveniet cum id quod tenetur quam illo soluta optio nihil maxime, corrupti alias fugit iusto unde officia repellat. Deleniti, veniam! Quod sed vitae rem blanditiis similique unde molestias dignissimos nisi possimus. Eum, itaque?",
                            CreateDate = new DateTime(2021, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/2.jpg",
                            Status = true,
                            Title = "Kimyager: Walter White",
                            WriterId = 2
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 2,
                            Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Magni quos harum in! Deserunt dicta dolore, ea vero eos fugit expedita voluptatum eius pariatur error assumenda nihil, illo quaerat a alias, obcaecati animi quibusdam quam consectetur quisquam fugiat? Sequi quas eos temporibus officiis excepturi sunt vero praesentium id quibusdam! Officiis ab repellat inventore qui enim quae ipsum consequuntur, temporibus harum culpa maxime est doloribus provident a magnam unde at saepe nostrum similique eaque corrupti adipisci dolor amet commodi! Atque id aspernatur impedit molestiae autem? Impedit rerum inventore molestiae ipsa similique aliquam iste amet debitis placeat! Fugit praesentium eligendi officiis ullam, sint distinctio, neque ratione maiores consequatur in, quasi facilis nesciunt dolorem. Fugiat quibusdam harum impedit tempore ipsa, tenetur ipsum id deleniti?",
                            CreateDate = new DateTime(2022, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/3.jpg",
                            Status = true,
                            Title = "Fifa 2022 Ekim Sonunda Çıkıyor",
                            WriterId = 3
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 3,
                            Content = "Lorem ipsum, dolor sit amet consectetur adipisicing elit. Iure corporis quasi sunt exercitationem, consequatur, optio dolores eum totam omnis nesciunt dolor veniam repudiandae atque alias veritatis iusto? Odit voluptatibus sapiente aliquid. Dicta dolores possimus harum voluptas iusto labore, mollitia atque alias id debitis dignissimos in cum illo corrupti! Doloremque quod, necessitatibus ducimus saepe optio iusto possimus quasi at sed magnam fuga perspiciatis beatae vero modi recusandae fugit! Saepe doloremque veritatis accusamus exercitationem a consequuntur natus aliquam, provident impedit iste modi nam corporis quidem minus, earum magni nesciunt, illo facere molestias dolor alias maiores! Tenetur dolores architecto numquam fugiat voluptates fugit. Rem eligendi explicabo aliquid corporis recusandae repellendus magni sit voluptatem necessitatibus quas magnam consectetur cumque accusamus placeat, ratione similique sed accusantium cum beatae, adipisci fugit nobis excepturi perferendis! Suscipit nam eius cum voluptate impedit, repudiandae, laudantium explicabo nisi molestiae eos fugiat cupiditate. Ipsam cupiditate quidem quo in cum, soluta et dolores repellendus porro ut nesciunt odit quasi necessitatibus maiores! Praesentium dolorum, doloribus porro odit laboriosam repellat. Aperiam quas hic optio provident rerum nostrum facere sit commodi eum alias, atque neque.",
                            CreateDate = new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/1.jpg",
                            Status = true,
                            Title = "Into The Night",
                            WriterId = 1
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Itaque voluptatibus temporibus numquam iure minima quam animi sit, laudantium quia fugit ea error. Nemo itaque repellendus placeat reiciendis voluptates rerum quidem voluptatibus autem a dicta voluptas, ratione quod repellat corrupti eum veniam inventore illo natus qui animi! Id minima a temporibus voluptas modi aperiam dolore, aliquid non sapiente ullam rem nobis, repudiandae magnam qui aspernatur, quibusdam nemo saepe. Sunt exercitationem aliquid nihil ducimus vitae quam soluta, eveniet neque aspernatur praesentium aut officiis quidem totam impedit, sint voluptatem earum, veritatis cum voluptates atque iure? Quisquam vero esse nostrum architecto. Molestias soluta neque voluptas voluptates rerum velit laudantium ex in odio consectetur aut amet possimus culpa commodi natus quibusdam nam maxime tempore eveniet, nostrum cupiditate aperiam eaque. Culpa temporibus placeat officiis architecto voluptatem illo ex nam consequuntur illum fugiat nihil similique officia quidem exercitationem sapiente, tenetur minus! Labore hic, aut rem ea aspernatur nulla, magni a quaerat cupiditate laudantium error autem velit mollitia perspiciatis beatae dolor assumenda, maiores possimus voluptatibus quisquam accusamus quo doloribus alias corporis. Ex dignissimos aperiam eos qui ut sequi vel illo, voluptate voluptas ullam iste reiciendis? Tenetur at voluptas laboriosam ad dolor. Quidem id unde nemo sint consectetur consequuntur laudantium incidunt. Sit porro odio dolorum quaerat assumenda modi quo molestias vero hic, voluptas molestiae iusto quos? Facere, reiciendis a fugit architecto libero, cumque, perspiciatis reprehenderit hic earum dolor pariatur dolorem! Quia expedita architecto maxime ea fuga veritatis eius ratione. Neque quas beatae porro excepturi veniam! Ipsum dolore voluptas rerum.",
                            CreateDate = new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/8.jpg",
                            Status = true,
                            Title = "Pyhton ile Veri Analizi",
                            WriterId = 1
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Content = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus porro perspiciatis, fugiat qui vel voluptatibus voluptatum molestias harum expedita quasi. Odit facere, iste excepturi qui exercitationem maxime numquam dolores, aperiam error provident commodi. Neque beatae alias necessitatibus perspiciatis aliquam molestias accusantium odio nam cumque ad ipsa, incidunt fuga quisquam. Asperiores minima tempore molestiae itaque voluptate officiis dolorum similique quas excepturi, repellat animi aliquid magni sint tempora earum amet? Dolores laudantium atque velit est corrupti dolore, vel possimus accusamus nemo, quisquam tempore repellendus id. Ducimus dolores dolor accusantium repudiandae nam esse corporis iusto vitae iure exercitationem quasi error voluptas eveniet autem sit dolorum facere, ipsa neque quaerat ipsum at rerum cum. Accusamus exercitationem harum omnis in officiis ullam quaerat. Sint necessitatibus nam illum quo neque mollitia dolores delectus, molestiae, unde doloribus ea eos inventore incidunt, quam iste magnam porro fuga a numquam assumenda? Ullam nihil illo praesentium esse facere sint. Animi dolore laudantium iste facere nobis fugit nostrum assumenda itaque praesentium. Nihil voluptate ea voluptatum, suscipit veritatis cupiditate quam vitae rem dolores omnis animi consequuntur ad magni maiores! Totam distinctio omnis saepe sunt enim ex dolorem, laborum, mollitia deleniti ducimus qui cupiditate doloribus quam architecto velit ut a, ab quisquam optio? Accusamus, ipsam eligendi. Accusantium aspernatur sit quas nemo explicabo magnam aliquam odit quisquam quasi quia odio tempore, molestiae labore est rerum mollitia dicta maxime alias perferendis soluta ratione. Earum, tempore?",
                            CreateDate = new DateTime(2023, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            ImageUrl = "/web/images/6.jpg",
                            Status = true,
                            Title = "C# ile Asenkron Metodlar",
                            WriterId = 2
                        });
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Yazılım",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            Name = "Oyun",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            Name = "Film",
                            Status = true
                        },
                        new
                        {
                            Id = 4,
                            Name = "Teknoloji",
                            Status = true
                        });
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BlogId")
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BlogId");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BlogId = 4,
                            Content = "çok faydalı bir içerik!",
                            Date = new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Title = "Teşekkürler",
                            UserName = "Ali Yıldırım"
                        },
                        new
                        {
                            Id = 2,
                            BlogId = 3,
                            Content = "çok ama çok beğendim kaleminize sağlık.",
                            Date = new DateTime(2022, 6, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Title = "Harika",
                            UserName = "Gizem Çınar"
                        },
                        new
                        {
                            Id = 3,
                            BlogId = 2,
                            Content = "merhaba içerik biraz daha genişletilebilirse daha faydalı olur.",
                            Date = new DateTime(2023, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Title = "Tavsiye",
                            UserName = "Aslı Yıldız"
                        },
                        new
                        {
                            Id = 4,
                            BlogId = 4,
                            Content = "bu içeriği herkese öneriyorum.",
                            Date = new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = true,
                            Title = "Öneri",
                            UserName = "Mert Kaya"
                        });
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.NewsLetter", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("NewsLetters");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Writer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("About")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Writers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Deneme",
                            Mail = "bahadirhakan@blog.com",
                            Name = "Bahadır Hakan",
                            Password = "111",
                            Status = true
                        },
                        new
                        {
                            Id = 2,
                            About = "Deneme",
                            Mail = "aysecinar@blog.com",
                            Name = "Ayşe Çınar",
                            Password = "333",
                            Status = true
                        },
                        new
                        {
                            Id = 3,
                            About = "Deneme",
                            Mail = "cemkaya@blog.com",
                            Name = "Cem Kaya",
                            Password = "000",
                            Status = true
                        });
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Blog", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Category", "Category")
                        .WithMany("Blogs")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Blog.Entities.Concrete.Writer", "Writer")
                        .WithMany("Blogs")
                        .HasForeignKey("WriterId");

                    b.Navigation("Category");

                    b.Navigation("Writer");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Comment", b =>
                {
                    b.HasOne("Blog.Entities.Concrete.Blog", "Blog")
                        .WithMany("Comments")
                        .HasForeignKey("BlogId");

                    b.Navigation("Blog");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Blog", b =>
                {
                    b.Navigation("Comments");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Category", b =>
                {
                    b.Navigation("Blogs");
                });

            modelBuilder.Entity("Blog.Entities.Concrete.Writer", b =>
                {
                    b.Navigation("Blogs");
                });
#pragma warning restore 612, 618
        }
    }
}
