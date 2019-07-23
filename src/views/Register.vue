<template>
    <!-- <div class="register">
        <form class="form-inline mb-2 centerStuff" @submit.prevent="register">
            <input class="form-control mx-1" type="text" v-model="newUser.username" placeholder="name">
            <input class="form-control mx-1" type="email" v-model="newUser.email" placeholder="email">
            <input class="form-control mx-1" type="password" v-model="newUser.password" placeholder="password">
            <button class="form-control btn button-color-go" type="submit">Create Account</button>
        </form>
    </div> -->
    <div class="register">
        <form class="form-horizontal" @submit.prevent="register">
            <fieldset>
                <div id="legend">
                    <legend class="">Register</legend>
                </div>
                
                <div class="control-group">
                    <!-- Username -->
                    <label class="control-label"  for="username">Username</label>
                    <div class="controls">
                        <input type="text" id="username" v-model="newUser.username" placeholder="" class="input-xlarge">
                        <p class="help-block">Username can contain any letters or numbers, without spaces</p>
                    </div>
                </div>
            
                <div class="control-group">
                    <!-- E-mail -->
                    <label class="control-label" for="email">E-mail</label>
                    <div class="controls">
                        <input type="text" id="email" v-model="newUser.email" placeholder="" class="input-xlarge">
                        <p class="help-block">Please provide your E-mail</p>
                    </div>
                </div>
            
                <div class="control-group">
                    <!-- Password-->
                    <label class="control-label" for="password">Password</label>
                    <div class="controls">
                        <input type="password" id="password" v-model="newUser.password" placeholder="" class="input-xlarge">
                        <p class="help-block">Password should be at least 6 characters</p>
                    </div>
                </div>
            
                <div class="control-group">
                <!-- Password -->
                    <label class="control-label"  for="password_confirm">Password (Confirm)</label>
                    <div class="controls">
                        <input type="password" id="password_confirm" name="password_confirm" placeholder="" class="input-xlarge">
                        <p class="help-block">Please confirm password</p>
                    </div>
                </div>
            
                <div class="control-group">
                    <!-- Button -->
                    <div class="controls">
                        <button class="btn btn-success">Register</button>
                    </div>
                </div>
            </fieldset>
        </form>
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
            }
        }
    };
</script>