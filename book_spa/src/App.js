
import React, {Component} from 'react';
import Books from './components/books';
import './App.css';

    class App extends Component {
      state = {
        books: []
      }
      componentDidMount() {
        fetch("http://localhost:8080/api/book")
        .then(res => res.json())
        .then((data) => {
          this.setState({ books: data })
        })
        .catch(console.log)
      }
      render () {
        return (
          <Books contacts={this.state.books} />
        );
      }
    }

    export default App;
