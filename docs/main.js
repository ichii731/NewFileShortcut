const router = new VueRouter({
    mode: 'history',
    routes: [
        { path: 'NewFileShortcut/', component: httpVueLoader('./vue/top.vue') },
        { path: 'NewFileShortcut/tutorial', component: httpVueLoader('./vue/tutorial.vue') },
        { path: 'NewFileShortcut/release', component: httpVueLoader('./vue/release.vue') },
        { path: 'NewFileShortcut/vkey', component: httpVueLoader('./vue/vkey.vue') }
    ]
})

const app = new Vue({
    el: "#app",
    router
});