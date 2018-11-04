import React from "react";
import axios from "axios";

class ViewAll extends React.Component {
  state = {};

  componentDidMount = () => {
    axios.get("/api/jobs").then(resp => {
      this.setState(
        {
          data: resp
        },
        console.log(resp)
      );
    });
  };

  render() {
    return <div>blahblabla</div>;
  }
}

export default ViewAll;
