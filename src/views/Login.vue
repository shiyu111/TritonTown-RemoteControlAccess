
<template>
  <div class="login_form">
    <div class= "login_box">
      <strong>Username</strong>: <input type="text"  class="qxs-ic_user qxs-icon" v-model="userName">
	  <br />
	  <strong>Password</strong>: <input type="text"  class="qxs-ic_password qxs-icon" v-model="password">
      <!--<button class="login_btn el-button el-button&#45;&#45;primary is-round" type="primary" round>登录</button>-->
	  <br />
      <el-button class="login_btn" @click.native="login" type="primary" round :loading="isBtnLoading">login</el-button>
	  <br />
		<span style="float:left; color:#A9A9AB;" @click="signup">sign up</span>
		<span style="float:right; color: #A9A9AB" @click="forgetpassword">forget password</span>
    </div>
  </div>
</template>
 
 
 
<script>
//  import { userLogin } from '../../api/api';
 
  export default {
    data() {
      return {
        userName: '',
        password: '',
        isBtnLoading: false
      }
    },
    created () {
      if(JSON.parse( localStorage.getItem('user')) && JSON.parse( localStorage.getItem('user')).userName){
        this.userName = JSON.parse( localStorage.getItem('user')).userName;
        this.password = JSON.parse( localStorage.getItem('user')).password;
      }
    },
    computed: {
      btnText() {
        if (this.isBtnLoading) return 'loading---';
		return 'success!'
      }
    },
    methods: {
      login() {
        if (!this.userName) {
          this.$message.error('Please Enter Username');
          return;
        }
        if (!this.password) {
          this.$message.error('Please Enter Password');
          return;
        }
 
      }
    }
  }
</script>
<style>
  .login_form {
	width: 1000px;
    padding-top: 5%;
    padding-left: 10%;
    padding-right: 10%;
	padding-bottom: 5%;
  }
  .login_box{
	border: 5px solid #00649C;
	border-radius: 25px;
	padding: 10% 10% 10% 10%;
	width: 500px; 
	height: 250px;
	text-align: center; 
	margin:auto  
  }
  .qxs-ic_user {
    background-size: 13px 15px;
    background-position: 3%;
    margin-bottom: 20px;
  }
  .qxs-ic_password {
    background-size: 13px 15px;
    background-position: 3%;
    margin-bottom: 20px;
  }
  .login_logo {
    height: 100%;
  }
  .login_btn {
    width: 50px;
    font-size: 16px;
    background: -webkit-linear-gradient(left, #FFFFFF); /* Safari 5.1 - 6.0 */
    background: -o-linear-gradient(right, #FFFFFF); /* Opera 11.1 - 12.0 */
    background: -moz-linear-gradient(right, #FFFFFF); /* Firefox 3.6 - 15 */
    background: linear-gradient(to right, #FFFFFF); /* 标准的语法 */
  }
</style>
