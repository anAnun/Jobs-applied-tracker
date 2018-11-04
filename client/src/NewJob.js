import React from "react";
import axios from "axios";

class NewJob extends React.Component {
  state = {
    company: "",
    position: "",
    dateApplied: "",
    website: "",
    followUp: ""
  };

  submit = () => {
    const myPromise = axios.post("api/jobs", {
      Company: this.state.company,
      Position: this.state.position,
      DateApplied: this.state.dateApplied,
      Website: this.state.website,
      FollowUp: this.state.followUp
    });
    myPromise.then(this.props.history.push("/home"));
  };

  render() {
    return (
      <div className="body">
        <label>Componay:</label>
        <br />
        <input
          value={this.state.company}
          onChange={e =>
            this.setState({
              company: e.target.value
            })
          }
        />
        <br />
        <label>Posish:</label>
        <br />
        <input
          value={this.state.position}
          onChange={e =>
            this.setState({
              position: e.target.value
            })
          }
        />
        <br />
        <label>DateAPli:</label>
        <br />
        <input
          value={this.state.dateApplied}
          onChange={e =>
            this.setState({
              dateApplied: e.target.value
            })
          }
        />
        <br />
        <label>Website:</label>
        <br />
        <input
          value={this.state.website}
          onChange={e => {
            this.setState({ website: e.target.value });
          }}
        />

        <br />
        <label> FollowUp: </label>
        <br />
        <input
          value={this.state.followUp}
          onChange={e => {
            this.setState({ followUp: e.target.value });
          }}
        />
        <br />
        <button className="btn btn-success bord" onClick={this.submit}>
          K submiot
        </button>
      </div>
    );
  }
}

export default NewJob;
