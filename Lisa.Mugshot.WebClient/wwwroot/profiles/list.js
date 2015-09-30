import {HttpClient} from "aurelia-http-client"

export class List {
    activate() {
        var webapi = new HttpClient().configure(http => {
            http.withBaseUrl("http://localhost:14823")
        });

        return webapi.get("/profiles").then(response => {
            this.profiles = response.content
        });
    }
}