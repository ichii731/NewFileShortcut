const router = new VueRouter({
    mode: 'history',
    base: '/NewFileShortcut/',
    routes: [
        { path: '/', component: httpVueLoader('./vue/top.vue') },
        { path: '/tutorial', component: httpVueLoader('./vue/tutorial.vue') },
        { path: '/release-log', component: httpVueLoader('./vue/release.vue') },
        { path: '/vkey', component: httpVueLoader('./vue/vkey.vue') }
    ]
})

const app = new Vue({
    el: "#app",
    router
});