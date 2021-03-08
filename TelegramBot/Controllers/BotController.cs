using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types;

namespace TelegramBot.Controllers
{
    [ApiController]
    [Route("api/bot")]
    public class BotController: ControllerBase
    {
        [HttpPost]
        public async Task<ActionResult> Post ([FromBody] Update update)
        {
            TelegramBotClient client = new TelegramBotClient("1674207985:AAEIY2mPWtEloT1Lvj1VW33UZN4go9gm99A");

            if(update.Type == Telegram.Bot.Types.Enums.UpdateType.Message)
            {
                await client.SendTextMessageAsync(update.Message.From.Id, "answer");
            }

            return Ok();
        }
    }
}
