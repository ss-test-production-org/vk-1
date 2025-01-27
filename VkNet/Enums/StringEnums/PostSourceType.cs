﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace VkNet.Enums.SafetyEnums;

/// <summary>
/// На данный момент поддерживаются следующие типы источников записи на стене,
/// значение которых указываются в поле
/// type:
/// </summary>
[StringEnum]
[JsonConverter(typeof(StringEnumConverter), typeof(SnakeCaseNamingStrategy))]
public enum PostSourceType
{
	/// <summary>
	/// Запись создана через основной интерфейс сайта (http://vk.com/).
	/// </summary>
	Vk,

	/// <summary>
	/// Запись создана через виджет на стороннем сайте.
	/// </summary>
	Widget,

	/// <summary>
	/// Запись создана приложением через API.
	/// </summary>
	Api,

	/// <summary>
	/// Запись создана посредством импорта RSS-ленты со стороннего сайта.
	/// </summary>
	Rss,

	/// <summary>
	/// Запись создана посредством отправки SMS-сообщения на специальный номер.
	/// </summary>
	Sms
}