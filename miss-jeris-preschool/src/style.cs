html {
  margin: 0;
  padding: 0;
}

#app {
  margin: 0;
  padding: 0;
}

body {
  font-family: "simple-kind-of-girl", "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
  background: rgb(216, 125, 219);
  background: linear-gradient(0deg, rgb(235, 105, 105) 24%, rgb(216, 125, 219) 47%, rgb(36, 186, 255) 72%);
  background-repeat: no-repeat;
  background-attachment: fixed;
  height: 100%;
  color: rgb(67, 11, 11);
  width: 100%;
  margin: 0;
  padding: 0;
  background-size: cover;
  overflow-x: hidden;
  display: flex;
  flex-direction: column;
}

@font-face {
  font-family: "simple-kind-of-girl";
  src: url("./assets/simple-kind-of-girl-font/SimpleKindOfGirl-mnnm.ttf");
  font-size: xx-large;
  font-weight: bold;
}
.header {
  background-color: rgb(238, 243, 246);
  width: 100%;
  min-width: 100%;
  max-width: 100%;
  display: flex;
  flex-wrap: nowrap;
  flex-direction: row;
  flex-flow: row;
  justify-content: center;
  align-items: center;
  margin: 0;
  padding: 0;
}

#headerimg {
  width: 4%;
  max-width: 4%;
  max-height: 4%;
}

.header-options {
  border-radius: 5px;
  padding: 1%;
  flex: 1 2 2 2 2;
  height: 5%;
  max-height: 5%;
  min-height: 5%;
  gap: 3%;
  width: 5%;
  border: none;
  border-color: none;
}
.header-options button {
  border: none;
  height: 5%;
  min-height: 5%;
  max-height: 5%;
  border-style: none;
  font-family: "simple-kind-of-girl", "Lucida Sans", "Lucida Sans Regular", "Lucida Grande", "Lucida Sans Unicode", Geneva, Verdana, sans-serif;
  padding-top: 1%;
  padding-bottom: 1%;
  padding-right: 1%;
  font-size: xx-large;
  padding-left: 1%;
}
.header-options button #aboutme {
  background-color: rgb(255, 233, 93);
  color: rgb(67, 11, 11);
}
.header-options button #aboutme :hover {
  background-color: rgb(255, 253, 199);
  color: rgb(99, 29, 64);
}
.header-options button #aboutme :focus {
  background-color: rgb(196, 144, 24);
  color: rgb(18, 2, 35);
}
.header-options button #info {
  background-color: rgb(235, 105, 105);
  color: rgb(67, 11, 11);
}
.header-options button #info :hover {
  background-color: rgb(255, 179, 179);
  color: rgb(99, 29, 64);
}
.header-options button #info :focus {
  background-color: rgb(108, 14, 44);
  color: rgb(18, 2, 35);
}
.header-options button #pricing {
  background-color: rgb(36, 186, 255);
  color: rgb(67, 11, 11);
}
.header-options button #pricing :hover {
  background-color: rgb(144, 248, 255);
  color: rgb(99, 29, 64);
}
.header-options button #pricing :focus {
  background-color: rgb(19, 69, 187);
  color: rgb(18, 2, 35);
}
.header-options button #home {
  background-color: rgb(255, 233, 93);
  color: rgb(67, 11, 11);
}
.header-options button #home :hover {
  background-color: rgb(255, 253, 199);
  color: rgb(99, 29, 64);
}
.header-options button #home :focus {
  background-color: rgb(196, 144, 24);
  color: rgb(18, 2, 35);
}

.img-slider {
  background: rgb(216, 125, 219);
}

.contentbg {
  background: rgb(216, 125, 219);
  background: linear-gradient(0deg, rgb(235, 105, 105) 24%, rgb(216, 125, 219) 47%, rgb(36, 186, 255) 72%);
  background-repeat: no-repeat;
  background-attachment: fixed;
  height: 100%;
  margin-left: 15%;
  margin-right: 15%;
  margin-top: 0;
  margin-bottom: 5%;
}

.content {
  width: 100%;
  background-color: rgb(255, 253, 199);
  background: rgb(255, 253, 199);
  margin-right: 15%;
  margin-top: 1%;
  margin-bottom: 5%;
  margin-left: 15%;
  padding: 1%;
}

.myheader {
  font-size: xx-large;
  font-weight: bold;
}

/*# sourceMappingURL=style.cs.map */
