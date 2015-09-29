export class App {
    configureRouter(config, router) {
        config.map([
            { route: "profiles", moduleId: "profiles/list" }
        ]);
    }
}