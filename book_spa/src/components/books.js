import React from 'react'

    const Books = ({ contacts: books }) => {
      return (
        <div>
          <center><h1>Books</h1></center>
          {books.map((book) => (
            <div class="card">
              <div class="card-body">
                <h5 class="card-title">{book.title}</h5>
                <h6 class="card-subtitle mb-2 text-muted">{book.author}</h6>
                <p class="card-text">{book.publisher}</p>
              </div>
            </div>
          ))}
        </div>
      )
    };

    export default Books