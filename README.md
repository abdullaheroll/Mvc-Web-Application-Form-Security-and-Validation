# Mvc-Web-Application-Form-Security-and-Validation

Kod bloğu, bir post isteği gönderildiğinde çalışan bir eylem yöntemini (Action Method) içeriyor.

İlk olarak, gelen email adresinin formatının geçerli olup olmadığını kontrol ediliyor. Eğer format geçerli değilse, geri dönüş değeri olarak bir JSON nesnesi döndürülüyor. Bu nesnenin success değeri false, message değeri ise "Invalid email format." şeklinde ayarlanıyor.

Daha sonra, gelen ad, email, konu ve mesaj metinleri escape ediliyor. Burada amaç, bu metinlerin HTML/XML kodlarının doğru şekilde işlenmesini sağlamak ve XSS saldırılarından korunmak.

Son olarak, anti-CSRF token kontrolü yapılıyor. Bu token, formların güvenliğini sağlamak için kullanılan bir yöntemdir. Token, formu oluşturan sayfaya özel olarak oluşturulur ve sunucu tarafından saklanır. Form gönderildiğinde, token da gönderilir ve sunucu tarafından doğrulanır. Bu şekilde, formun sadece formu oluşturan sayfa tarafından gönderilmesi sağlanır ve CSRF saldırılarından korunulur. Eğer token doğrulanamazsa, geri dönüş değeri olarak bir JSON nesnesi döndürülür ve success değeri false, message değeri ise "Invalid anti-CSRF token." şeklinde ayarlanır.

TR: Dilediğiniz gibi kullanıp, geliştirebilirsiniz.

👋 Merhaba, ben @abdullaheroll...
👀 Yazılımla ilgileniyorum...
📫 Bana nasıl ulaşılır;
❤ Instagram: apo.zip
⚡ Facebook: apozip
☸ Mail: info@abdullaherol.com
⚘ Web Sitesi: abdullaherol.com
EN: You can use and develop it as you wish.

👋 Hi, I’m @abdullaheroll...
👀 I’m interested in Software...
📫 How to reach me;
❤ Instagram: apo.zip
⚡ Facebook: apozip
☸ Mail: info@abdullaherol.com
⚘ Web Site: abdullaherol.com
