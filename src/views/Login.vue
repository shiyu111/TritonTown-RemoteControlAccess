<template>
    <div class="login">
        <div class="form-group pt-2">
            <form class="form-inline mb-2 centerStuff" v-if="loginForm" @submit.prevent="loginUser">
                <input class="form-control mx-1" type="email" v-model="creds.email" placeholder="email">
                <input class="form-control mx-1" type="password" v-model="creds.password" placeholder="password">
                <button type="submit" class="btn button-color-go">Login</button>
            </form>
            <form class="form-inline mb-2 centerStuff" v-else @submit.prevent="register">
                <input class="form-control mx-1" type="text" v-model="newUser.username" placeholder="name">
                <input class="form-control mx-1" type="email" v-model="newUser.email" placeholder="email">
                <input class="form-control mx-1" type="password" v-model="newUser.password" placeholder="password">
                <button class="form-control btn button-color-go" type="submit">Create Account</button>
            </form>
        </div>
        <div @click="loginForm = !loginForm">
            <p v-if="loginForm">No account Click to Register</p>
            <p v-else>Already have an account click to Login</p>
        </div>
    </div>
</template>

<script>
    export default {
        name: "login",
        mounted() {
            //checks for valid session
            this.$store.dispatch("authenticate");
        },
        data() {
            return {
                loginForm: true,
                creds: {
                    email: "",
                    password: ""
                },
                newUser: {
                    email: "",
                    password: "",
                    username: ""
                }
            };
        },
        methods: {
            register() {
                // debugger
                console.log(this.newUser)
                this.$store.dispatch("register", this.newUser);
            },
            loginUser() {
                this.$store.dispatch("login", this.creds);
            }
        }
    };
</script>