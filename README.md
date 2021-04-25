![image](https://i.giphy.com/media/GHE74VClT7q5FiqoHY/giphy.gif)



## Some Design Patterns

Creational Design Patterns | Structural Design Patterns|Behavioral Design Patterns|
-------------------------- | --------------------------|--------------------------|
Singleton | Decorator |Chain of Responsibility
Prototype | Adapter   |Mediator
Builder | Bridge      |Observer
Factory Method | Proxy|Strategy






**Singleton Design Pattern** 1️⃣

Bu pattern bir sınıfın sadece bir instance'a sahip olmasını benimserken bu instance'a global bir erişim sağlayan bir Creational Design Pattern'dır. Bu instance ya doğru zamanda alınmalıdır yada ilk kullanılacağı yerde alınmalıdır.
Bu pattern SOLID prensiplerinden biri olan Single Responsibility Prensibini ihlal eden bazı problemlerin çözümünde kullanılır.Instance'a global erişim verilmesi unutulmamalıdır.Bu pattern'ın kullanım alanlarından birisi bir sınıfın kaç tane instance'ının olduğunun kontrol edilmek istenmediği bir durum örnek verilebilir.Bir constructor çağrısının her zaman yeni bir nesne döndürdüğünü göz önünde bulundurursak bu pattern sıradan bir constructor çağrısı ile birlikte uygulanamaz.Öncelikle instance'ımızı private static veri üyesi olarak bildirmeliyiz.Daha sonra bu instance'a erişim sağlayan public static üye fonksiyonu tanımlamalıyız.Programcı bu instance'ı çağırmak istediğinde sınıf ismi ile birlikte çağırmalıdır.
Singleton tıpkı global bir değişken gibi programın herhangi bir yerinden bazı nesnelere erişim sağlar.Yapılması gerekenleri şöyle özetleyebiliriz.
1) Singleton sınıfı için private static bir attribute tanımla.
2) Private üyeye erişim sağlayabilmek için public static bir erişim fonksiyonu tanımla.
3) Constructor'ı private veya protected yap.
Gerçek hayattan bir örnek vermek gerekirse bir arabanın arabayı süren kişilerin kimliklerinden  bağımsız olarak  sadece bir tane direksiyonu olabilir.İstenildiği takdirde herhangi bir sayıda Singleton instance'ı oluşturmaya izin verebilirsiniz bunun için değiştirilmesi gereken tek kod  getInstance() methodunun gövdesidir.



**Prototype Design Pattern** 🤖

Prototip, kodunuzu sınıflarına bağımlı hale getirmeden mevcut nesneleri kopyalamanıza izin veren creational bir design pattern'dır. Bir nesneniz olduğunu ve onun bir kopyasını oluşturmak istediğinizi varsayalım. Normalde aynı sınıftan yeni bir nesne oluşturmalısınız. Ardından, orijinal nesnenin değerlerini yeni nesneye kopyalamanız gerekir. Ama bir sorun var.
Tüm nesneler bu şekilde kopyalanamaz çünkü nesnenin bazı alanları private olabilir ve nesnenin dışından erişilemeyebilirler. Bir sorun daha var. Bir kopya oluşturmak için nesnenin sınıfını bilmeniz gerektiğinden, kodunuz bu sınıfa bağımlı hale gelir. Bu pattern, kopyalanmayı destekleyen tüm nesneler için ortak bir interface bildirir. Bu ara interface birim, kodunuzu o nesnenin sınıfına bağlamadan bir nesneyi kopyalamanıza olanak tanır. böyle bir interface genellikle yalnızca tek bir clone() methodu içerir. clone() methodunun implementasyonu tüm sınıflarda çok benzerdir. Klonlamayı destekleyen nesneye prototip denir. private alanları bile kopyalayabilirsiniz çünkü çoğu programlama dili, nesnelerin aynı sınıfa ait diğer nesnelerin private alanlarına erişmesine izin verir. İşleyiş şekli şöyledir: çeşitli şekillerde yapılandırılmış bir dizi nesne oluşturursunuz. Yapılandırdığınız gibi bir nesneye ihtiyacınız olduğunda, sıfırdan yeni bir nesne oluşturmak yerine sadece bir prototip klonlarsınız. Gerçek hayatta, bir ürünün seri üretimine başlamadan önce çeşitli testler yapmak için prototipler kullanılır. Ancak bu durumda prototipler herhangi bir gerçek üretime katılmaz ve bunun yerine pasif bir rol oynar.Gerçek hayattan bir örnek vermek gerekirse mitoz bölünmeyi örnek verebiliriz. Mitoz bölünmeden sonra, bir çift özdeş hücre oluşur. Orijinal hücre bir prototip görevi görür ve kopyanın oluşturulmasında aktif rol alır.



**Builder Design Pattern** 🏗️

Örneğin, bir Ev nesnesinin nasıl oluşturulacağını düşünelim. Basit bir ev inşa etmek için dört duvar ve bir zemin inşa etmeniz, bir kapı takmanız,pencerelerini takmanız ve bir çatı inşa etmeniz gerekir. Peki ya arka bahçesi ve diğer başka özellikleri olan  daha büyük, daha lüks bir ev inşa etmek istersek? Satın alınan evi yaratılacak nesnenin talebi olarak düşünürsek ve evlerin ana yapısının benzer olduğunuda göz önünde bulundurusak, inşaatcının yapacağı işlem aslında hep aynıdır. Bir ev düşünelim bu evde kapı,pencere,çatı vb. yapılar evin ana yapısıdır. Burada gelen taleplere göre evin ekstra olarak istenen özellikleri bir araya getirilerek hızlıca ev nesnesi ortaya çıkartılır.



**Factory Method Design Pattern** 🏭

Factory Method, Base sınıfta nesneler oluşturmak için bir interface sağlayan, ancak alt sınıfların oluşturulacak nesnelerin türünü değiştirmesine izin veren creational bir design pattern'dır.Bir nesne oluşturmak için bir interface tanımlayın, ancak alt sınıfların hangi sınıf nesnesinin hayata getirileceğine karar vermesine izin verin.
Bir lojistik yönetim uygulaması oluşturduğunuzu hayal edin.İlk olarak sadece kamyonlarla taşıma yapılsın, bu nedenle kodumuzun büyük bir kısmı Kamyon sınıfında bulunur.
Bir süre sonra işleri büyütmeye karar verdik ve kamyonla taşımacılığın yanında ek olarak deniz taşımacılığı işine girdiğimizi düşünelim.
Uygulamaya Gemi sınıfı eklemek, tüm kod tabanında değişiklik yapılmasını gerektirir. Dahası, daha sonra uygulamaya başka bir ulaşım türü eklemeye karar verirsek, muhtemelen tüm bu değişiklikleri tekrar yapmamız gerekecektir.İşte Factory Method bunun gibi problemlere yönelik bir çözüm sunar.


**Decorator Design Pattern** 🖌️

Bu desen  var olan sınıf nesnesinin dinamik olarak yapısını değiştirmektedir ve nesneye yeni özellikler, davranışlar eklemek için kullanılır.Uygulamanın ilerleyen safhalarında gelen dinamik ihtiyaçlara göre var olan yapılarımızı dinamik olarak değiştirmeye yarayan bir modeldir.Bu dinamik değişiklikleri var olan nesnenin ana yapısını değiştirmeden yerine getirmesi bu desenin güzel özelliklerinden biridir.Bir Araba nesnemiz olduğunu düşünün ve arabamızın sis farı olmadığını düşünün , arabamızla sisli havalarda seyahat ederken zorluk çektiğimiz için hali hazırda var olan aracımıza ekstra olarak sis farı taktırarak arabamızı dekore etmiş oluyoruz.Yada bir cep telefonu nesnemiz olduğunu düşünün aynı telefonu daha bizden daha önceden almış ve düşürüp kırmış arkadaşlarımız olduğunu düşünün bu durumda aldığımız telefona ekran koruyucu taktırarak telefon nesnemizi ihtiyaçlarımıza göre dekore etmiş olduk.

**Adapter Design Pattern** 🔌

Adaptör, uyumsuz interfacelere sahip nesnelerin işbirliği yapmasına izin veren structural bir tasarım modelidir.Yurt dışı seyahate çıktığınızı düşünün,eğer ülkemizde kullanılan prizlerden farklı prizlerin olduğu bir ülkeye gitmişseniz elektronik cihazlarınızı sarj edebilmeniz için çevirici bir seyahat adaptörüne ihtiyacınız olacaktır.Yada bir borsa izleme uygulaması oluşturduğunuzu düşünün.Uygulama,  verileri birden çok kaynaktan XML biçiminde alıyor diyelim.Siz ileride 3rd-part bir kütüphane kullanarak uygulamanızı geliştirmek istediniz diyelim ama bu kütüphaneninde sadece JSON formatında datalarla çalıştığını düşünün ve bu bize bir problem yaratır ve canımızı sıkar.İşte bu tarz problemlerin çözümünde Adapter Design Pattern tercih edilir.


**Bridge Design Pattern** 🌉

Bridge Design Pattern büyük bir sınıfı birbirinden bağımsız olarak geliştirilebilen iki ayrı hiyerarşiye (abstraction and implementation) ayırmanıza olanak tanıyan structural  bir tasarım modelidir.Bir Şekil sınıfınızın olduğunu düşünün ve bu Şekil sınıfından türetilmiş Daire ve Kare sınıflarınız olduğunu düşünün.Bu sınıf hiyerarşisini renkleri içerecek şekilde genişletmek istiyorsunuz, bu nedenle Kırmızı ve Mavi şekiller içeren alt sınıflar oluşturmayı planlıyorsunuz diyelim. Hiyerarşiye yeni şekiller  ve renkler eklemek, hiyerarşiyi giderek büyütecektir. Renk ve şekil sayısı arttıkça durum iyice kötüye gidecektir.Bridge pattern'ı, kalıtımdan nesne kompozisyonuna geçerek bu sorunu çözmeye çalışır. Bunun anlamı, örneğin renkleri veya şekilleri ikisinden birini  ayrı bir sınıf hiyerarşisine çıkartmaktır.Bu yaklaşım sayesinde her yeni renk veya şekil eklendiğinde tek bir sınıf hiyerarşisinden devamlı alt sınıflara oluşturarak dallanmak yerine bir Şekil sınıfımız ve bu sınıftan türeyen Daire ve Kare isimli alt sınıflarımız olucak.Başka bir sınıf hiyerarşisinde ise Color base class'ı ve onun altında Kırmızı ve Mavi alt sınıfları olacak. Şu andan itibaren, yeni renkler eklemek Şekil sınıf hiyerarşisinin değiştirilmesini gerektirmeyecek ve bu durumun tersi de geçerli olacaktır.


**Chain of Responsibility** ⛓️

Chain of Responsibility pattern'da gelen bir request'i  handle etmeye yada oluşturulan sorumluluk zincirinde bir sonraki handler'a devretmeye dayanan bir yapı bulunmaktadır.  Öncelikle bir sorumluluk zinciri oluşturulmalıdır. Bu zincirin her halkasının gelen request'i  handle etme yeteneği bulunmalıdır. Bu sorumluluk zincirinde gelen request'i alıp,  önce sorumluluk zincirinin ilk halkasında handle etme kapasitesine göre handle edilebilir,eğer  handle edilemez ise bir sonraki handler'a yani sorumluluk zincirinin bir sonraki halkasına bu request iletilir.Gerçek hayattan örnek vermek gerekirse  ürün aldığımız bir mağazaya herhangi bir sebepten ötürü şikayetimizi dile getirmeye gittiğimiz zaman önce bizi bir görevli karşılar bu görevli sorunumuzu handle edebilirse handle eder eğer sorunumuzu çözemezse problemi handle etmesi için sorumluluk zincirinde bir sonraki halkaya yani kendisinden üst mevkide çalışan birine yönlendirir eğer o da sorunumuzu handle edemezse problemi handle etmesi için sorumluluk zincirinde bir sonraki halkaya mağaza müdürüne durumu iletir.Bu design pattern'ın çalışma prensibi bu şekildedir.



**Mediator Design Pattern** 🤝

Mediator yani arabulucu, nesneler arasındaki kaotik bağımlılıkları azaltmanıza izin veren behavioral bir design patterndır.Bu desen,nesneler arasındaki doğrudan iletişimi kısıtlar ve onları yalnızca bir aracı nesnesi aracılığıyla işbirliği yapmaya zorlar. Böylelikle etkileşime girecek nesneler arasında loose couple bir ilişki temin edilmektedir.
Bu desene gerçek hayattan bir örnek vermek gerekirse uçakların kule ile olan iletişimleri örnek verilebilir.Uçaklar kendi aralarında iletişime geçmezler ve kule aracılığı ile iletişim kurarlar.Uçak nesnelerimiz mediator nesnesine karşılık gelen kule arabulucuğu ile birbirleri ile haberleşirler.


**Observer Design Pattern** 👀

Observer yani gözlemci, gözlemlediği nesnede meydana gelen herhangi bir olay hakkında birden çok nesneyi bilgilendirmek için bir mekanizma tanımlamanıza izin veren behavioral bir design patterndır.İki tür nesneye sahip olduğunuzu düşünelim. Bu nesneler Müşteri ve Mağaza nesneleri olsun.Müşteri, çok yakında mağazada satışa sunulması gereken belirli bir marka ürünle çok ilgileniyor olsun.Müşteri her gün mağazayı ziyaret edebilir ve ürün mevcudiyetini kontrol edebilir.Öte yandan Mağaza, her yeni ürün piyasaya çıktığında tüm müşterilere tonlarca e-posta gönderebilir. Bu, bazı müşterilerin devamlı mağazaya gelip ürünü kontrol etmelerini önler.Aynı zamanda, yeni ürünlerle ilgilenmeyen diğer müşterileri de rahatsız edebilir.İşte burada bir problem bir anlaşmazlık ortaya çıkıyor.İlginç bir duruma sahip olan nesneye genellikle subject denir, ancak aynı zamanda durumundaki değişiklikler hakkında diğer nesnelere de bildirimde bulunacağı için, biz ona publisher diyelim.Publisher’ın  durumundaki değişiklikleri izlemek isteyen diğer tüm nesnelere subscriber adını verelim.Observer pattern Publisher sınıfına bir subscription mekanizması eklenmesini tavsiye eder.Böylece tek tek nesneler o publisher'dan gelen bir olay akışını subscribe edebilir veya etmeyebilir.Başka bir örnek vermek gerekirse bir e-ticaret sitesinde kişin gerçekleştirdiği sipariş sonucunda siparişin geçtiği adımları gözlemleme aşamaları bu desene örnek olarak verilebilir. 


**Strategy Design Pattern** ⤴️

Strategy pattern, bir algoritma ailesi tanımlamanıza, ve bunlardan her birini ayrı bir sınıfa koymanıza ve nesnelerini birbirinin yerine geçebilir hale getirmenize olanak tanıyan behavioral bir design patterndır.Bir  navigasyon uygulaması oluşturmaya karar verdiniz diyelim.Uygulama için en çok istenen özelliklerden biri otomatik rota oluşturması olsun. Bir kullanıcı bir adres girebilmeli ve haritada görüntülenen hedefe giden en hızlı rotayı görebilmelidir.İlk olarak rotaları yalnızca yollar üzerinde oluşturuyorsunuz. Araba ile seyahat edenler için faydalı bir uygulama.Ama herkes araba kullanmak zorunda değil. Bir sonraki güncellemede, yürüyüş rotaları oluşturma seçeneği eklediniz. Hemen ardından, insanların rotalarında toplu taşıma kullanmalarına izin vermek için başka bir seçenek eklediniz.İş açısından bakıldığında, uygulama başarılı olsa da, teknik kısım size birçok baş ağrısına neden olur. Her yeni bir yönlendirme algoritması eklediğinizde, Navigasyon base class'ının boyutu artacaktır, ve bir noktada bakımı çok zor hale gelecektir.
Algoritmalardan birinde yaptığınız herhangi bir değişiklik, ister ufak bir hata düzeltmesi olsun isterse büyük bir değişiklik olsun, tüm sınıfı etkiler ve halihazırda çalışan kodda bir hata oluşturma olasılığını arttırır.Strategy pattern, belirli bir işi birçok farklı şekilde yapabilen bir sınıf oluşturmanızı ve tüm bu algoritmaları Strategy adı verilen ayrı ayrı sınıflara çıkarmanızı önerir.Context olarak adlandırılan sınıf stratejilerden birine olan bir referansı tutabilmek için bir field'a sahip olmalıdır.
Context, çalışmayı kendi başına yürütmek yerine bağlantılı bir Strategy nesnesine devreder.İş için uygun bir algoritmanın seçilmesinden Context sorumlu değildir.Aslında Context stratejiler hakkında pek bir şey bilmez.Tüm stratejilerle aynı genel interface üzerinden çalışır.Buda seçilen strateji içinde enkapsüle edilmiş algoritmayı tetiklemek için yalnızca tek bir yöntemi ortaya çıkarır.Bu şekilde Context, concrete olan stratejilerden bağımsız hale gelir, böylece Context'in kodunu veya diğer stratejileri değiştirmeden yeni algoritmalar ekleyebilir veya mevcut olanları değiştirebilirsiniz.
