import React, { Component } from "react";
import "./App.css";
import ViewAll from "./ViewAll";
import NewJob from "./NewJob";
import { Route, withRouter } from "react-router-dom";

class App extends Component {
  state = {};
  home = () => {
    this.props.history.push("/home");
  };
  render() {
    return (
      <React.Fragment>
        <div className="App-header">
          <button
            className="btn Button"
            onClick={() => this.props.history.push("/home")}
          >
            Home
          </button>
          <button
            className="btn Button"
            onClick={() => this.props.history.push("/newjob")}
          >
            NEW JOB
          </button>
        </div>
        <Route exact path="/home" component={ViewAll} />
        <Route exact path="/newjob" component={NewJob} />
      </React.Fragment>
    );
  }
}
export default withRouter(App);
