# MeBlog-Rest-API
A simple Rest API built using ASP.Net core

-------------------------

Current supported endpoint:

- BlogController

  - GET: https://localhost:port/api/blogs

    By calling this endpoint you'll get all Blogs data (but with lazy load mechanism), it means that it won't provide you the data for its related entity, e.g: Post data.

    ```json
    [
        {
            "blogId": 1,
            "name": "Blog Lucu",
            "description": "Well, ini adalah blog yang saya buat untuk kumpulan cerita unik dan lucu.",
            "posts": null
        },
        {
            "blogId": 2,
            "name": "Blog Tech",
            "description": "Kumpulan artikel keren seputar teknologi",
            "posts": null
        },
        ....
    ]
    ```

  - GET: https://localhost:port/api/blogs/preload-data
    If you need all related data to be provided in the Blogs data that you get, you must call this endpoint, it will give you Post data that related to its Blog.

    ```json
    [
        {
            "blogId": 1,
            "name": "Blog Lucu",
            "description": "Well, ini adalah blog yang saya buat untuk kumpulan cerita unik dan lucu.",
            "posts": []
        },
        {
            "blogId": 4,
            "name": "Blog Gabut",
            "description": "Gabut bersama yuk!!",
            "posts": [
                {
                    "postId": 1,
                    "title": "Pertama kali naik TransJakarta dan Kereta!!",
                    "content": "Hi guys. Tidak jauh berbeda dari topik kemarin, saat ini saya akan menceritakan mengenai pengalaman saya naik Transakarta",
                    "blogId": 4
                },
                ....
            ]
        }
    ]
    ```

  - GET: https://localhost:port/api/blogs/{id}

  - GET: https://localhost:port/api/blogs/with-title?query=any-text

  - PUT: https://localhost:port/api/blogs/{id}

  - POST: https://localhost:port/api/blogs

  - DELETE: https://localhost:port/api/blogs/{id}

- PostController

  - GET: https://localhost:port/api/posts
  - GET: https://localhost:port/api/posts/{id}
  - PUT: https://localhost:port/api/posts/{id}
  - POST: https://localhost:port/api/posts
  - DELETE: https://localhost:port/api/posts/{id}