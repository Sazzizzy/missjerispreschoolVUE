html {
  background-color: rgb(249, 246, 244);
  margin: 0;
  padding: 0;
  font-family: "simple-kind-of-girl", "Gill Sans", sans-serif;
  overflow-x: hidden;
}

.ourHeader {
  font-family: "Cute-Notebook", "Gill Sans", sans-serif;
  display: flex;
  flex-direction: row;
  text-align: center;
  width: 100%;
  gap: 3%;
  align-items: center;
  justify-content: space-evenly;
  padding: 1%;
  height: fit-content;
}

.colorBlockBlue {
  display: flex;
  flex-direction: column;
  background-color: rgb(131, 216, 255);
  width: fit-content;
  color: rgb(9, 6, 86);
  padding: 5%;
  margin: 0;
  align-content: center;
  align-items: center;
  text-align: center;
}

.mybutton {
  border: solid 1px rgb(9, 6, 86);
  color: rgb(9, 6, 86);
  background-color: rgb(235, 105, 105);
  padding: 1%;
  font-family: "Cute-Notebook", "Gill Sans", sans-serif;
  border-radius: 3px;
  text-decoration: none;
}

.mybutton:hover {
  color: rgb(44, 39, 170);
  background-color: rgb(255, 161, 161);
  text-decoration: none;
}

.contentHeaders {
  width: fit-content;
  font-size: xx-large;
  color: rgb(9, 6, 86);
  border-radius: 5px;
  border-bottom: 3px dotted rgb(9, 6, 86);
  align-content: center;
  padding: 1%;
  margin: 0;
  text-align: center;
  font-family: "Cute-Notebook", "Gill Sans", sans-serif;
}

.aboutmesection {
  display: flex;
  flex-direction: row;
  align-items: center;
  align-content: center;
  text-align: left;
  width: 100%;
  max-width: 100%;
  gap: 4%;
  vertical-align: top;
  overflow: hidden;
  margin: 5%;
}

.aboutme {
  display: flex;
  flex-direction: column;
  align-items: center;
  align-content: center;
  text-align: left;
  width: fit-content;
  max-width: fit-content;
  vertical-align: top;
  text-align: left;
}

.portrait {
  align-content: space-between;
  width: 30%;
  max-width: 30%;
  max-height: auto;
  border-radius: 40px;
  display: block;
}

.headerlinks {
  text-decoration: none;
}

@media (max-width: 375px) {
  .headerlogo {
    width: 50%;
    max-width: 50%;
    max-height: 50%;
    margin: auto;
    display: block;
  }
  .aboutme .contentHeaders {
    font-family: "simple-kind-of-girl", "Gill Sans", sans-serif;
    text-align: right;
    flex-wrap: wrap;
    font-size: x-large;
    align-items: left;
    align-self: left;
    align-content: left;
    color: rgb(137, 3, 3);
    text-shadow: 3px rgb(255, 161, 161);
    padding-top: 5%;
    align-self: flex-start;
  }
}
@media (min-width: 376px) {
  .headerlogo {
    width: 20%;
    max-width: 20%;
    max-height: 20%;
    margin: auto;
    display: block;
  }
  .aboutme .contentHeaders {
    font-family: "simple-kind-of-girl", "Gill Sans", sans-serif;
    text-align: right;
    align-items: left;
    align-self: left;
    align-content: left;
    color: rgb(137, 3, 3);
    text-shadow: 3px rgb(255, 161, 161);
    padding-top: 5%;
    align-self: flex-start;
  }
}
@font-face {
  font-family: "simple-kind-of-girl";
  src: url("./assets/simple-kind-of-girl-font/SimpleKindOfGirl-mnnm.ttf");
  font-size: xx-large;
  font-weight: bold;
}
@font-face {
  font-family: "Cute-Notebook";
  src: url("./assets/CuteNotebookPersonalUse-7OAEV.ttf");
  font-size: xx-large;
  font-weight: bold;
}

/*# sourceMappingURL=style.cs.map */
