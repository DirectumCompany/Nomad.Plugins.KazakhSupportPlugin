using NpoComputer.Nomad.Contract.Extensions;
using System.Collections.Generic;

namespace NpoComputer.Nomad.Core.Plugins.KazakhSupportPlugin
{
  /// <summary>
  /// Плагин для преобразования служебных символов для казахских букв в корректные utf-8 символы.
  /// </summary>
  public class Plugin : ISoapTransformPlugin
  {
    /// <summary>
    /// Таблица замены кодов служебных символов для казахских букв в корректные utf-8 символы.
    /// </summary>
    private readonly Dictionary<int, char> _replacementMap = new Dictionary<int, char>(18)
    {
      { 1108, 'ә' },
      { 1107, 'ғ' },
      { 1116, 'қ' },
      { 1114, 'ң' },
      {  181, 'ө' },
      {  177, 'ұ' },
      { 8240, 'ү' },
      { 1115, 'һ' },
      { 1110, 'і' },
      { 1028, 'Ә' },
      { 1027, 'Ғ' },
      { 1036, 'Қ' },
      { 1034, 'Ң' },
      {  164, 'Ө' },
      {  166, 'Ұ' },
      { 8225, 'Ү' },
      { 1035, 'Һ' },
      { 1030, 'І' }
    };

    /// <summary>
    /// Выполняет инициализацию.
    /// </summary>
    public void Initialize()
    {
    }

    /// <summary>
    /// Преобразовывает SOAP-содержимое запросов к веб-сервису.
    /// </summary>
    /// <param name="message">SOAP-сообщение.</param>
    /// <returns>Преобразованное SOAP-сообщение.</returns>
    public string TransformInputMessage(string message) 
    {
      return message;
    }

    /// <summary>
    /// Преобразовывает SOAP-содержимое ответов веб-сервиса.
    /// </summary>
    /// <param name="message">SOAP-сообщение.</param>
    /// <returns>Преобразованное SOAP-сообщение.</returns>
    public string TransformOutputMessage(string message)
    {
      var array = new char[message.Length];

      for (var i = 0; i < message.Length; ++i)
      {
        var ch1 = message[i];

        array[i] = _replacementMap.TryGetValue(ch1, out var ch2) ? ch2 : ch1;
      }

      return new string(array);
    }
  }
}
