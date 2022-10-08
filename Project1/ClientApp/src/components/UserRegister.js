import React, { Component } from 'react';

export class UserRegister extends Component {

  constructor(props) {
    super(props);
    this.state = { register: Boolean, loading: true };
    
  }
  componentDidMount() {
    this.AccountCheck();
  }

  render() {
    return (
      <div>
        <h1>User Register Page</h1>

        <p>This is a simple example of a React component.</p>

        <p aria-live="polite"> <strong>{this.state.register} Evet</strong></p>

        <button className="btn btn-primary">Register</button>
      </div>
    );

  }
  async AccountCheck() {
    console.log("yes");
    
    const response = await fetch("account/register");
    const data = await response;
    console.log(data);
    this.setState({ register: data, loading: false });
  }
}
