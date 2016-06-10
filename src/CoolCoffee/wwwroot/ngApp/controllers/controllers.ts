namespace CoolCoffee.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
        public champions

        constructor(private $http:angular.IHttpService) {
            this.getChampion();
        }

        getChampion() {
            this.$http.get("https://global.api.pvp.net/api/lol/static-data/na/v1.2/champion?champData=skins&api_key=3b03777b-7555-4f2d-820f-f9d704c71fdc").then((data:any) => {

                this.champions = data;
                console.log(this.champions);
                
            });
        }

    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

}
