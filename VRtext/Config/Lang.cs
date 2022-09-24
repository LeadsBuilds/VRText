using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VRText.Config
{
    public class Lang
    {
        private List<KeyValuePair<string, string>> ptBR;
        private List<KeyValuePair<string, string>> enUS;

        private List<KeyValuePair<string, string>> currentLanguage;
        public Lang(string lang)
         {
           this.currentLanguage = this.getLanguage(lang);
         }

        private List<KeyValuePair<string, string>> getLanguage(string lang)
        {
            if (lang == "pt-BR")
            {
                setLanguage(lang);
                return this.ptBR;
            }
            setLanguage(lang);
            return this.enUS;
        }

        private void setLanguage(string lang)
        {
            switch(lang)
            {
                case "pt-BR":
                    this.ptBR = new List<KeyValuePair<string, string>>() {
                        new KeyValuePair<string, string>("sendButton", "Enviar"),
                        new KeyValuePair<string, string>("label1", "Histórico de mensagens:"),
                        new KeyValuePair<string, string>("removeButton", "Remover"),
                        new KeyValuePair<string, string>("sendAgainButton", "Reenviar"),
                        new KeyValuePair<string, string>("spotifyCheckBox", "Status do spotify"),
                        new KeyValuePair<string, string>("rotateCheckBox", "Rodar lista a cada"),
                        new KeyValuePair<string, string>("label2", "segundos"),
                        new KeyValuePair<string, string>("AddButton", ""),
                        new KeyValuePair<string, string>("addButtonLabel", "Adicionar à lista sem enviar"),
                        new KeyValuePair<string, string>("spotifyLabel", "🎵 Não é possível utilizar a lista rotativa enquanto o status do Spotify estiver habilitado."),
                        new KeyValuePair<string, string>("aboutButton", " Sobre"),
                        new KeyValuePair<string, string>("settingsButton", ""),
                        new KeyValuePair<string, string>("settingsLabel", "Configurações"),
                        new KeyValuePair<string, string>("rotatingTime", "10"),
                        new KeyValuePair<string, string>("typing", "caracteres restantes..."),
                        new KeyValuePair<string, string>("placeHolder", "Mensagem..."),
                        new KeyValuePair<string, string>("cooldown", "Enviando..."),
                        new KeyValuePair<string, string>("ClearListButton", "Apagar tudo"),
                    };
                break;

                case "en-US":
                    this.enUS = new List<KeyValuePair<string, string>>() {
                        new KeyValuePair<string, string>("sendButton", "Send"),
                        new KeyValuePair<string, string>("label1", "Message history:"),
                        new KeyValuePair<string, string>("removeButton", "Remove"),
                        new KeyValuePair<string, string>("sendAgainButton", "Send Again"),
                        new KeyValuePair<string, string>("spotifyCheckBox", "Spotify Status"),
                        new KeyValuePair<string, string>("rotateCheckBox", "Rotate list each"),
                        new KeyValuePair<string, string>("label2", "seconds"),
                        new KeyValuePair<string, string>("AddButton", ""),
                        new KeyValuePair<string, string>("addButtonLabel", "Add to list without sending it"),
                        new KeyValuePair<string, string>("spotifyLabel", "🎵 You are unable to use the rotating list while Spotify status is enabled."),
                        new KeyValuePair<string, string>("aboutButton", " About"),
                        new KeyValuePair<string, string>("settingsButton", ""),
                        new KeyValuePair<string, string>("settingsLabel", "Settings"),
                        new KeyValuePair<string, string>("rotatingTime", "10"),
                        new KeyValuePair<string, string>("typing", "characters remaining..."),
                        new KeyValuePair<string, string>("placeHolder", "Message..."),
                        new KeyValuePair<string, string>("cooldown", "Sending..."),
                        new KeyValuePair<string, string>("ClearListButton", "Clear all"),
                    };
                    break;
            }
        }

        public List<KeyValuePair<string, string>> getCurrentLanguage()
        {
            return this.currentLanguage;
        }

    }
}
