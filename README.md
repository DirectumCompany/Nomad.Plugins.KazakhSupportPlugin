Плагин поддержки казахского алфавита в мобильных приложениях DIRECTUM.

В связи с ограничениями платформы IS-Builder на поддержку только символов одной кодировки Windows-1251, DIRECTUM не позволяет работать со всеми символами казахского алфавита «из коробки». Для решения этой проблемы, на компьютерах с системой DIRECTUM взамен используемой по умолчанию кодировки c_1251.nls может быть установлена специальная кодировка c_1251kz.nls, в которой некоторые редко используемые спецсимволы заменены на символы соответствующих букв казахского алфавита (на рабочих местах при этом устанавливается специальный шрифт для корректного отображения этих спецсимволов). 

Плагин KazakhSupportPlugin позволяет корректно отображать указанные спецсимволы в мобильных приложениях DIRECTUM Solo и Jazz. В нем реализована замена кодов этих спецсимволов на utf8-коды соответствующих букв казахского алфавита.

Плагин требует сборку NpoComputer.Nomad.Contract.dll, содержащую определение открытых интерфейсов сервера NOMAD. Сборка входит в состав сервера NOMAD и располагается в каталоге с установленным сервером, по умолчанию: c:\inetpub\wwwroot\nomad\bin.
